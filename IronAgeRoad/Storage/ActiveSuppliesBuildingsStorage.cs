using System.Collections.Generic;
using CruelWorld.Account;

namespace CruelWorld.IronAgeRoad.Models
{
    public class ActiveSuppliesBuildingsStorage
    {
        private AccountParams accountParams;
        private RequestService _requestService;
        private List<CollectedSuppliesBuilding> CollectedSuppliesBuildings = new List<CollectedSuppliesBuilding>();

        public ActiveSuppliesBuildingsStorage(AccountParams accountParams, RequestService requestService)
        {
            this.accountParams = accountParams;
            this._requestService = requestService;
        }
        
        public void AddToStorage(CollectedSuppliesBuilding collectedSuppliesBuilding)
        {
            CollectedSuppliesBuildings.Add(collectedSuppliesBuilding);
        }
        
        public void StartCollection()
        {
            foreach (var collectedSuppliesBuilding in CollectedSuppliesBuildings)
            {
                collectedSuppliesBuilding.StartCollection(accountParams, _requestService);
            }
            
        }

    }
}