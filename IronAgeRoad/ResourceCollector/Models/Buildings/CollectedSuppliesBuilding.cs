using System;
using System.Threading.Tasks;
using CruelWorld.Account;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad.Models
{
    public class CollectedSuppliesBuilding
    {
        public int generateProductionTime;
        public int buildingId;
        public int constructionTime;
        public AccountParams accountParams;
        private RequestService _requestService;

        private const int minTimeCollectionOffset = 5000;
        private const int maxTimeCollectionOffset = 10000;

        public async void StartCollection(AccountParams accountParams, RequestService requestService)
        {
            this._requestService = requestService;
            this.accountParams = accountParams;
            await Task.Delay((constructionTime * 1000)+ 2000);
            StartManufacturingProducts();
        }

        private async void StartManufacturingProducts()
        {
            Payload payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = _requestService.currentRequestId,
                    RequestClass = "CityProductionService",
                    RequestData = JArray.Parse("[" + buildingId + ",4]"),
                    RequestMethod = "startProduction"
                }
            });
            await _requestService.SendRequest(accountParams, payload);
            WaitToCollection();
        }
        
        private async void WaitToCollection()
        {
            var offset = new Random().Next(minTimeCollectionOffset, maxTimeCollectionOffset);
            await Task.Delay((generateProductionTime) + offset);
            CollectMoney();
        }

        private async void CollectMoney()
        {
            Payload payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = _requestService.currentRequestId,
                    RequestClass = "CityProductionService",
                    RequestData = JArray.Parse("[[" + buildingId + "]]"),
                    RequestMethod = "pickupProduction"
                }
            });
            await _requestService.SendRequest(accountParams, payload);
            await Task.Delay(1000);
            StartManufacturingProducts();
        }
    }
}