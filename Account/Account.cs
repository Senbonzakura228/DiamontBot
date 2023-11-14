using System;
using CruelWorld.IronAgeRoad;

namespace CruelWorld.Account
{
    public class Account
    {
        public AccountParams accountParams;
        private IronAgeRoader ironAgeRoader;

        public Account(AccountParams accountParams)
        {
            this.accountParams = accountParams;

        }

        public void StartRoadToIronAge()
        {
            ironAgeRoader ??= new IronAgeRoader(accountParams);
            ironAgeRoader.Start();
        }
    }
}