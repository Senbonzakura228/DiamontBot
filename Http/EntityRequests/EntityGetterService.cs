using System;
using System.Text;
using System.Threading.Tasks;
using CruelWorld.Account;
using CruelWorld.EntityRequests.ResponseModel;
using CruelWorld.EntityRequests.ResponseModel.ResourceResponse;
using MyNameIsGiorgio.Http.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld.EntityRequests
{
    public class EntityGetterService
    {
        private RequestService requestService;
        private const int ResponseSplitLeft = 52;
        private AccountParams accountParams;

        public EntityGetterService(AccountParams accountParams, RequestService requestService)
        {
            this.requestService = requestService;
            this.accountParams = accountParams;
        }

        public async Task<int> GetNextCityMapId()
        {
            var payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = requestService.currentRequestId,
                    RequestClass = "StartupService",
                    RequestData = JArray.Parse(@"[]"),
                    RequestMethod = "getData"
                }
            });
            var result = await requestService.SendRequest(accountParams, payload);
            var startupDataResponse = JsonConvert.DeserializeObject(result).ToString();
            return HttpService.GetEntityByRequestMethod<CityMapResponse>(startupDataResponse, "getNextId")
                .responseData;
        }

        public async Task<PlayerResources?> GetPlayerResourcesInfo()
        {
            var payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = requestService.currentRequestId,
                    RequestClass = "ResourceService",
                    RequestData = JArray.Parse(@"[]"),
                    RequestMethod = "getPlayerResources"
                }
            });
            var result = await requestService.SendRequest(accountParams, payload);
            var resourceResponse = JsonConvert.DeserializeObject(result).ToString();
            var resources = HttpService
                .GetEntityByRequestMethod<ResourceResponse>(resourceResponse, "getPlayerResources")
                .responseData.resources;
            var convertedResult = new PlayerResources()
            {
                money = resources.money,
                strategy_points = resources.strategy_points,
                supplies = resources.supplies
            };

            return convertedResult;
        }

        public async Task<CityMapEntity[]> GetPlayerCityMapEntities()
        {
            var payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = requestService.currentRequestId,
                    RequestClass = "StartupService",
                    RequestData = JArray.Parse(@"[]"),
                    RequestMethod = "getData"
                }
            });
            var result = await requestService.SendRequest(accountParams, payload);
            var startupResponse = JsonConvert.DeserializeObject(result).ToString();
            var startupData = HttpService
                .GetEntityByRequestMethod<StartupDataResponse>(startupResponse, "getData")
                .responseData.city_map.entities;
            return startupData;
        }
    }
}