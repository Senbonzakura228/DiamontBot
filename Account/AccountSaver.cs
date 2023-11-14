using System.Linq;
using MyNameIsGiorgio.Http.Service;

namespace CruelWorld.Account
{
    public static class AccountSaver
    {
        public static AccountParams[] AccountsParams;

        public static void UpdateAccount(AccountParams account)
        {
            for (int i = 0; i < AccountsParams.Length; i++)
            {
                if (AccountsParams[i].UserKey == account.UserKey)
                {
                    AccountsParams[i] = account;
                    break;
                }
            }
        }

        public static void Save()
        {
            var saveService = new JsonDataSaveService();
            var saveData = new AccountParamsStorage
            {
                accountsParams = AccountsParams,
            };
            saveService.SaveData("Accounts.json", saveData);
        }
    }
}