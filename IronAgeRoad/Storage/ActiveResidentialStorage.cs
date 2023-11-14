using System.Collections.Generic;
using CruelWorld.Account;

namespace CruelWorld.IronAgeRoad.Models
{
    public class ActiveResidentialStorage
    {
        private AccountParams accountParams;
        private RequestService _requestService;
        private List<CollectedMoneyBuilding> CollectedMoneyBuildings = new List<CollectedMoneyBuilding>();

        public ActiveResidentialStorage(AccountParams accountParams, RequestService requestService)
        {
            this.accountParams = accountParams;
            this._requestService = requestService;
        }
        public void AddToStorage(CollectedMoneyBuilding collectedMoneyBuilding)
        {
            CollectedMoneyBuildings.Add(collectedMoneyBuilding);
        }

        public void StartCollection()
        {
            foreach (var collectedMoneyBuilding in CollectedMoneyBuildings)
            {
                collectedMoneyBuilding.StartCollection(accountParams, _requestService);
            }
            
        }
    }
}