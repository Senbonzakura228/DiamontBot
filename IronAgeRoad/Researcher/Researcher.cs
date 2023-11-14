using System;
using System.Threading.Tasks;
using CruelWorld.Account;
using CruelWorld.EntityRequests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad
{
    public class Researcher
    {
        private int currentResearchIndex = 0;
        private AccountParams _accountParams;
        private RequestService _requestService;

        public ResearchTechnology[] Technologies = new[]
        {
            new ResearchTechnology()
            {
                StrategyPointCost = 3,
                Name = "wheel",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 0,
                isLastInvestment = false,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 1,
                SuppliesNeccesity = 0,
                MoneyNeccesity = 0,
                Name = "wheel",
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 5,
                Name = "construction",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 0,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 5,
                Name = "slingshots",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 200,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 5,
                Name = "chalets",
                SuppliesNeccesity = 200,
                MoneyNeccesity = 100,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 6,
                Name = "cultivation",
                SuppliesNeccesity = 100,
                MoneyNeccesity = 200,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 6,
                Name = "horseback_riding",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 250,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 6,
                Name = "thatched_houses",
                SuppliesNeccesity = 200,
                MoneyNeccesity = 150,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 8,
                Name = "smithery",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 350,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 8,
                Name = "phalanx",
                SuppliesNeccesity = 200,
                MoneyNeccesity = 0,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 7,
                Name = "paths",
                SuppliesNeccesity = 100,
                MoneyNeccesity = 0,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 9,
                Name = "siege_weapons",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 500,
                isLastInvestment = true,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 10,
                Name = "rooftilehouses",
                SuppliesNeccesity = 0,
                MoneyNeccesity = 0,
                isLastInvestment = false,
            },
            new ResearchTechnology()
            {
                StrategyPointCost = 3,
                Name = "rooftilehouses",
                SuppliesNeccesity = 100,
                MoneyNeccesity = 250,
                isLastInvestment = true,
            },
        };

        public Researcher(AccountParams accountParams, RequestService requestService)
        {
            this._accountParams = accountParams;
            this._requestService = requestService;
        }

        public async Task StartResearch()
        {
            if (_accountParams.currentResearchIndex > Technologies.Length) return;
            currentResearchIndex = _accountParams.currentResearchIndex;
            await Start();
        }

        private async Task<PlayerResources> getCurrentResources()
        {
            EntityGetterService entityGetterService = new EntityGetterService(_accountParams, _requestService);
            PlayerResources? resources = await entityGetterService.GetPlayerResourcesInfo();
            return resources;
        }

        private async Task Start()
        {
            if (currentResearchIndex > Technologies.Length) return;
            var currentResources = await getCurrentResources();
            Console.WriteLine(currentResources.strategy_points);
            Console.WriteLine(Technologies[currentResearchIndex].StrategyPointCost);
            if (currentResources.money >= Technologies[currentResearchIndex].MoneyNeccesity
                && currentResources.supplies >= Technologies[currentResearchIndex].SuppliesNeccesity
                && currentResources.strategy_points >= Technologies[currentResearchIndex].StrategyPointCost)
            {
                await Research();
            }
            else
            {
                _accountParams.currentResearchIndex = currentResearchIndex;
                AccountSaver.UpdateAccount(_accountParams);
            }
        }

        private async Task Research()
        {
            Console.WriteLine("research");
            Payload payload;
            payload = new Payload(new PayloadParams[]
            {
                new PayloadParams()
                {
                    ClassName = "ServerRequest",
                    RequestId = _requestService.currentRequestId,
                    RequestClass = "ResearchService",
                    RequestData = new JArray(Technologies[currentResearchIndex].Name,
                        Technologies[currentResearchIndex].StrategyPointCost),
                    RequestMethod = "spendForgePoints"
                }
            });
            await _requestService.SendRequest(_accountParams, payload);
            if (Technologies[currentResearchIndex].isLastInvestment)
            {
                payload = new Payload(new PayloadParams[]
                {
                    new PayloadParams()
                    {
                        ClassName = "ServerRequest",
                        RequestId = _requestService.currentRequestId,
                        RequestClass = "ResearchService",
                        RequestData = new JArray(Technologies[currentResearchIndex].Name),
                        RequestMethod = "payTechnology"
                    }
                });
                await _requestService.SendRequest(_accountParams, payload);
            }

            currentResearchIndex += 1;
            await Task.Delay(500);
            await Start();
        }
    }
}