using System;
using System.Threading.Tasks;
using CruelWorld.Account;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad.Models
{
    public class CollectedMoneyBuilding
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
            await Task.Delay(constructionTime * 1000);
            WaitToCollection();
        }

        private async void WaitToCollection()
        {
            Console.WriteLine(generateProductionTime);
            var offset = new Random().Next(minTimeCollectionOffset, maxTimeCollectionOffset);
            await Task.Delay(generateProductionTime + 1000);
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
            WaitToCollection();
        }
    }
}