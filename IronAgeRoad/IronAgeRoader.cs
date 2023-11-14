using System;
using System.Linq;
using System.Threading.Tasks;
using CruelWorld.Account;
using CruelWorld.EntityRequests;
using CruelWorld.IronAgeRoad.Models;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad
{
    public class IronAgeRoader
    {
        private AccountParams _accountParams;
        private RequestService requestService = new RequestService();
        private ActiveResidentialStorage _activeResidentialStorage;
        private ActiveSuppliesBuildingsStorage _activeSuppliesBuildingsStorage;


        public IronAgeRoader(AccountParams accountParams)
        {
            _accountParams = accountParams;
            _activeResidentialStorage = new ActiveResidentialStorage(_accountParams, requestService);
            _activeSuppliesBuildingsStorage = new ActiveSuppliesBuildingsStorage(_accountParams, requestService);
        }

        public async void Start()
        {
     //       if (_accountParams.currentResearchIndex == ) return;
            if (!_accountParams.tutorialHasComplete)
            {
                await StartTutorialExecution();
                _accountParams.tutorialHasComplete = true;
                AccountSaver.UpdateAccount(_accountParams);
            }
            await StartBuildingCollecting();
            await Researching();
        }

        private async Task StartTutorialExecution()
        {
            foreach (var (step, i) in TutorialStepsRequestDataStorage.StepsData.Select((value, i) => (value, i)))
            {
                PayloadParams[] payloadParams = new PayloadParams[step.Length];


                foreach (var (data, j) in step.Select((value, j) => (value, j)))
                {
                    payloadParams[j] = new PayloadParams()
                    {
                        ClassName = "ServerRequest",
                        RequestId = requestService.currentRequestId,
                        RequestClass = data.RequestClass,
                        RequestData = data.RequestData,
                        RequestMethod = data.RequestMethod
                    };
                    if (step.Length > 1)
                    {
                        requestService.currentRequestId += 1;
                    }
                }

                Payload payload = new Payload(payloadParams);
                await requestService.SendRequest(_accountParams, payload);
            }
        }

        private async Task StartBuildingCollecting()
        {
            var cityMapNextId = new EntityGetterService(_accountParams, requestService).GetNextCityMapId().Result;
            Console.WriteLine(cityMapNextId);
            var buildingCollector = new BuildingPlacer.BuildingPlacer(_accountParams, requestService, cityMapNextId,
                _activeResidentialStorage, _activeSuppliesBuildingsStorage);
            await buildingCollector.StartCollect();
        }

        private async Task Researching()
        {
            Researcher researcher = new Researcher(_accountParams, requestService);
            await researcher.StartResearch();
        }
    }
}
// WinnerAsd27932
// WinterLux44649
// MoonlightJojo60930