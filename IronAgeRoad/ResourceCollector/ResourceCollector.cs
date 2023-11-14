using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CruelWorld.Account;
using CruelWorld.EntityRequests;
using CruelWorld.EntityRequests.ResponseModel;
using CruelWorld.IronAgeRoad.Models;
using CruelWorld.IronAgeRoad.Models.Place;
using MyNameIsGiorgio.IronAgeRoad.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad.BuildingPlacer
{
    public class BuildingPlacer
    {
        private AccountParams _accountParams;
        private int _cityMapNextId;
        private RequestService _requestService;
        private ActiveResidentialStorage _activeResidentialStorage;
        private ActiveSuppliesBuildingsStorage _activeSuppliesBuildingsStorage;

        private string[] collectedBuildingNames =
            new[] {"R_StoneAge_Residential", "P_StoneAge_Hunter", "P_BronzeAge_Pottery"};


        public BuildingPlacer(AccountParams accountParams, RequestService requestService, int cityMapNextId,
            ActiveResidentialStorage activeResidentialStorage,
            ActiveSuppliesBuildingsStorage activeSuppliesBuildingsStorage)
        {
            this._activeResidentialStorage = activeResidentialStorage;
            this._activeSuppliesBuildingsStorage = activeSuppliesBuildingsStorage;
            _requestService = requestService;
            _cityMapNextId = cityMapNextId;
            _accountParams = accountParams;
        }

        public async Task StartCollect()
        {
            if (_accountParams.startBuildingHasPlaced == false)
            {
                await PlaceAdditionBuildings();
                _accountParams.startBuildingHasPlaced = true;
                AccountSaver.UpdateAccount(_accountParams);
            }

            await CollectResources();
        }

        private async Task CollectResources()
        {
            var cityMapEntities =
                await new EntityGetterService(_accountParams, _requestService).GetPlayerCityMapEntities();
            var moneyBuildingsIds = PrepareReadinessMoneyBuildingsIds(cityMapEntities);
            if (moneyBuildingsIds.Length > 0)
            {
                await CollectMoney(moneyBuildingsIds);
            }

            if (_accountParams.currentResearchIndex >= 5)
            {
                var suppliesBuildingsIds = PrepareReadinessSuppliesBuildingsIds(cityMapEntities);
                if (suppliesBuildingsIds.Length > 0)
                {
                    await CollectSupplies(suppliesBuildingsIds);
                }
                var freeSuppliesBuildingsIds = PrepareFreeSuppliesBuildingsIds(cityMapEntities).ToList();
                freeSuppliesBuildingsIds.AddRange(suppliesBuildingsIds.ToList());
                await StartProduction(freeSuppliesBuildingsIds.ToArray());
            }
        }

        private int[] PrepareReadinessMoneyBuildingsIds(CityMapEntity[] cityMapEntities)
        {
            List<int> ids = new List<int>();
            foreach (var cityMapEntity in cityMapEntities)
            {
                if (cityMapEntity.state?.__class__ == "ProductionFinishedState" &&
                    (cityMapEntity.type == "residential" || cityMapEntity.type == "main_building"))
                {
                    ids.Add(cityMapEntity.id);
                }
            }

            return ids.ToArray();
        }

        private async Task CollectMoney(int[] ids)
        {
            Payload payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = _requestService.currentRequestId,
                    RequestClass = "CityProductionService",
                    RequestData = JArray.Parse("[" + new JArray(ids) + "]"),
                    RequestMethod = "pickupProduction"
                }
            });
            await _requestService.SendRequest(_accountParams, payload);
        }

        private int[] PrepareReadinessSuppliesBuildingsIds(CityMapEntity[] cityMapEntities)
        {
            List<int> ids = new List<int>();
            foreach (var cityMapEntity in cityMapEntities)
            {
                if (cityMapEntity.state?.__class__ == "ProductionFinishedState" &&
                    cityMapEntity.type == "production")
                {
                    ids.Add(cityMapEntity.id);
                }
            }

            return ids.ToArray();
        }

        private async Task CollectSupplies(int[] ids)
        {
            Payload payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = _requestService.currentRequestId,
                    RequestClass = "CityProductionService",
                    RequestData = JArray.Parse("[" + new JArray(ids) + "]"),
                    RequestMethod = "pickupProduction"
                }
            });
            await _requestService.SendRequest(_accountParams, payload);
        }

        private int[] PrepareFreeSuppliesBuildingsIds(CityMapEntity[] cityMapEntities)
        {
            List<int> ids = new List<int>();
            foreach (var cityMapEntity in cityMapEntities)
            {
                if (cityMapEntity.state.__class__ == "IdleState" &&
                    cityMapEntity.type == "production")
                {
                    ids.Add(cityMapEntity.id);
                }
            }

            return ids.ToArray();
        }

        private async Task StartProduction(int[] ids)
        {
            foreach (var id in ids)
            {
                Payload payload = new Payload(new PayloadParams[]
                {
                    new PayloadParams()
                    {
                        ClassName = "ServerRequest",
                        RequestId = _requestService.currentRequestId,
                        RequestClass = "CityProductionService",
                        RequestData = JArray.Parse("[" + id + ",5]"),
                        RequestMethod = "startProduction"
                    }
                });
                await _requestService.SendRequest(_accountParams, payload);
            }
        }

        private async Task PlaceAdditionBuildings()
        {
            Payload payload;
            BuildingsToPlace[] storage = new StructuresPlacementStorage().buildingPositions;
            foreach (var (item, i) in storage.Select((value, j) => (value, j)))
            {
                _cityMapNextId += 1;
                DateTime currentTime = DateTime.UtcNow;
                var unixTime = ((DateTimeOffset) currentTime).ToUnixTimeSeconds();
                var requestData = new PlaceBuildingEntity(
                    item.cityentityId,
                    new ConstructionState(unixTime),
                    _cityMapNextId,
                    item.type,
                    item.x,
                    item.y
                );

                foreach (var collectedBuildingName in collectedBuildingNames)
                {
                    if (item.cityentityId == collectedBuildingName)
                    {
                        if (item.type == "residential")
                        {
                            _activeResidentialStorage.AddToStorage(new CollectedMoneyBuilding()
                            {
                                buildingId = _cityMapNextId,
                                constructionTime = 22,
                                generateProductionTime = 310000,
                            });
                        }
                        else if (item.type == "production")
                        {
                            _activeSuppliesBuildingsStorage.AddToStorage(new CollectedSuppliesBuilding()
                            {
                                buildingId = _cityMapNextId,
                                constructionTime = 22,
                                generateProductionTime = 14410000,
                            });
                        }

                        break;
                    }
                }

                payload = new Payload(new PayloadParams[]
                {
                    new PayloadParams()
                    {
                        ClassName = "ServerRequest",
                        RequestId = _requestService.currentRequestId,
                        RequestClass = "CityMapService",
                        RequestData = JArray.Parse("[" + JsonConvert.SerializeObject(requestData) + "]"),
                        RequestMethod = "placeBuilding"
                    }
                });
                await _requestService.SendRequest(_accountParams, payload);
            }

            await Task.Delay(1000);
        }

        private void AddStartBuildingsToStorages()
        {
            CollectedMoneyBuilding[] collectedMoneyBuilding = new[]
            {
                new CollectedMoneyBuilding()
                {
                    generateProductionTime = 3610000,
                    buildingId = 34,
                    constructionTime = 5,
                },
            };

            CollectedSuppliesBuilding[] collectedSuppliesBuildings = new[]
            {
                new CollectedSuppliesBuilding()
                {
                    generateProductionTime = 14410000,
                    buildingId = 31,
                    constructionTime = 5,
                },
            };
            foreach (var moneyBuilding in collectedMoneyBuilding)
            {
                _activeResidentialStorage.AddToStorage(moneyBuilding);
            }

            foreach (var collectedSuppliesBuilding in collectedSuppliesBuildings)
            {
                _activeSuppliesBuildingsStorage.AddToStorage(collectedSuppliesBuilding);
            }
        }
    }
}