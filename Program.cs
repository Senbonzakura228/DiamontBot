using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using CruelWorld.Account;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            // StreamWriter streamWriter = new StreamWriter("logs.txt", true);
            // streamWriter.WriteLine("--------------------------------------------------------");
            // streamWriter.WriteLine("START");
            // streamWriter.WriteLine("--------------------------------------------------------");
            // streamWriter.Close();

            var path = "Accounts.json";
            string jsonFile = File.ReadAllText(path);
            
              AccountParamsStorage? accountParamsStorage = JsonConvert.DeserializeObject<AccountParamsStorage>(jsonFile);
              AccountSaver.AccountsParams = accountParamsStorage.accountsParams;
              
              Account.Account[] accounts = new Account.Account[accountParamsStorage.accountsParams.Length];
              foreach (var (value, i) in accountParamsStorage.accountsParams.Select(((value, i) => (value,i))))
              {
                  accounts[i] = new Account.Account(value);
              }
            
              foreach (var account in accounts)
              {
                  account.StartRoadToIronAge();    
              }
            
            
            string exitCommand = Console.ReadLine();
            AccountSaver.Save();
            exitCommand = Console.ReadLine();
        }
    }
}