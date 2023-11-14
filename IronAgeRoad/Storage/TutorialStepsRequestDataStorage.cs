using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CruelWorld.IronAgeRoad
{
    public class TutorialStepsRequestDataStorage
    {
        public static IEnumerable<FOERequestData[]> StepsData => _stepsData;

        private static FOERequestData[][] _stepsData =
        {
            new[]
            {
                new FOERequestData("TutorialService", "track", JArray.Parse(@"[
               {
                   ""finishedStep"": true,
                   ""stepId"": ""welcome"",
                   ""target"": ""RAGU_BUBBLE"",
                   ""type"": ""buttonClick"",
                   ""version"": ""1.0.26"",
                   ""__class__"": ""TutorialFlowTracking""
               }]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //   {
            //       ""stepId"": ""residential"",
            //       ""subStep"": ""openConstructionMenu"",
            //       ""target"": ""HUD_CONSTRUCTION_MENU_BUTTON"",
            //       ""type"": ""buttonClick"",
            //       ""version"": ""1.0.26"",
            //       ""__class__"": ""TutorialFlowTracking""
            //   }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //       ""stepId"": ""residential"",
            //       ""subStep"": ""selectHut"",
            //       ""target"": ""HUD_CONSTRUCTION_MENU_HUT_OPTION"",
            //       ""type"": ""buttonClick"",
            //       ""version"": ""1.0.26"",
            //       ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""residential"",
            //         ""subStep"": ""placeHut"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""population"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""coins"",
            //         ""subStep"": ""collectFromHut"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""coins"",
            //         ""subStep"": ""coinsStock"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""coins"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("InventoryService", "getGreatBuildings", JArray.Parse(@"[]")),
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //   {
            //     ""__class__"": ""TutorialFlowTracking"",
            //     ""version"": ""1.0.26"",
            //     ""stepId"": ""hunter"",
            //     ""type"": ""buttonClick"",
            //     ""target"": ""HUD_CONSTRUCTION_MENU_BUTTON"",
            //     ""subStep"": ""openConstructionMenu""
            //  }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""hunter"",
            //         ""subStep"": ""clickProductionTab"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_PRODUCTION_TAB"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""hunter"",
            //         ""subStep"": ""selectHunter"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_HUNTER_OPTION"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""hunter"",
            //         ""subStep"": ""placeHunter"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""hunter"", ""1.0.26"", ""first_session""]"))
            },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""connection"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""produce"",
            //         ""subStep"": ""clickHunter"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""produce"",
            //         ""subStep"": ""selectHunterProductionOption"",
            //         ""target"": ""PRODUCTION_WINDOW_OPTION_0"",
            //         ""type"": ""mouseClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""produce"",
            //         ""subStep"": ""hunterProductionStarted"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""produce"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""openResearchTree"",
            //         ""target"": ""HUD_RESEARCH_MENU_BUTTON"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""forgePointsBar"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""researchStiltHouses"",
            //         ""target"": ""RESEARCH_STILT_HOUSES_TECHNOLOGY"",
            //         ""type"": ""mouseClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""spendForgePoints"",
            //         ""target"": ""RESEARCH_SPEND_FORGE_POINTS"",
            //         ""type"": ""mouseClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""technologyResearched"",
            //         ""target"": ""RESEARCH_TECHNOLOGY_RESEARCHED_WINDOW_OK_BUTTON"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""celebrateNewAge"",
            //         ""target"": ""CELEBRATE_NEW_AGE_WINDOW"",
            //         ""type"": ""closeWindow"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""research"",
            //         ""subStep"": ""reachBronzeAge"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""research"",
            //         ""subStep"": ""forgePointsInfo"",
            //         ""target"": """",
            //         ""type"": ""moduleUnloaded"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""research"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("InventoryService", "getGreatBuildings", JArray.Parse(@"[]")),
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //   {
            //     ""__class__"": ""TutorialFlowTracking"",
            //     ""version"": ""1.0.26"",
            //     ""stepId"": ""happiness"",
            //     ""type"": ""buttonClick"",
            //     ""target"": ""HUD_CONSTRUCTION_MENU_BUTTON"",
            //     ""subStep"": ""openConstructionMenu""
            //  }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""happiness"",
            //         ""subStep"": ""clickDecorationTab"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_DECORATION_TAB"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""happiness"",
            //         ""subStep"": ""selectMemorial"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_MEMORIAL_OPTION"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""happiness"",
            //         ""subStep"": ""placeMemorial"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""happiness"",
            //         ""subStep"": ""happinessHud"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""happiness"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""openQuestTab"",
            //         ""target"": ""HUD_QUEST_MANAGER"",
            //         ""type"": ""mouseClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""closeQuestTab"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("InventoryService", "getGreatBuildings", JArray.Parse(@"[]")),
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //   {
            //     ""__class__"": ""TutorialFlowTracking"",
            //     ""version"": ""1.0.26"",
            //     ""stepId"": ""quests"",
            //     ""type"": ""buttonClick"",
            //     ""target"": ""HUD_CONSTRUCTION_MENU_BUTTON"",
            //     ""subStep"": ""openConstructionMenu""
            //  }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""clickResidentialTab"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_RESIDENCE_TAB"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""selectStiltHouse"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_STILT_HOUSE_OPTION"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""placeStiltHouse"",
            //         ""target"": ""ISO_SCENE"",
            //         ""type"": ""cityClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""openCompletedQuestTab"",
            //         ""target"": ""HUD_QUEST_MANAGER"",
            //         ""type"": ""mouseClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""finishedStep"": true,
            //         ""stepId"": ""quests"",
            //         ""subStep"": ""collectQuestReward"",
            //         ""target"": ""QUEST_COMPLETED_BUTTON"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                   ""quests"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""premium"",
            //         ""subStep"": ""premiumStock"",
            //         ""target"": ""RAGU_BUBBLE"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("InventoryService", "getGreatBuildings", JArray.Parse(@"[]")),
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //   {
            //     ""__class__"": ""TutorialFlowTracking"",
            //     ""version"": ""1.0.26"",
            //     ""stepId"": ""premium"",
            //     ""type"": ""buttonClick"",
            //     ""target"": ""HUD_CONSTRUCTION_MENU_BUTTON"",
            //     ""subStep"": ""openConstructionMenu""
            //  }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""premium"",
            //         ""subStep"": ""selectLonghouse"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_LONG_HOUSE_OPTION"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //     {
            //         ""stepId"": ""premium"",
            //         ""subStep"": ""selectLonghouse"",
            //         ""target"": ""HUD_CONSTRUCTION_MENU_LONG_HOUSE_OPTION"",
            //         ""type"": ""buttonClick"",
            //         ""version"": ""1.0.26"",
            //         ""__class__"": ""TutorialFlowTracking""
            //     }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""premium"",
            //        ""subStep"": ""placeLonghouse"",
            //        ""target"": ""ISO_SCENE"",
            //        ""type"": ""cityClick"",
            //        ""version"": ""1.0.26"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""premium"", ""1.0.26"", ""first_session""]"))
            },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""end"", ""1.0.26"", ""first_session""]"))
            },
            // new[]
            // {
            //     new TutorialStepsRequestData("NoticeIndicatorService", "remove", JArray.Parse(@"[
            //     ""end"", 71]"))
            // },
            new[]
            {
                new FOERequestData("ResearchService", "spendForgePoints", JArray.Parse(@"[""spears"",3]"))
            },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""welcome"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""welcome"",
            //        ""subStep"": ""generalGrivusMessage"",
            //        ""target"": ""RAGU_BUBBLE"",
            //        ""type"": ""buttonClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""welcome"",
            //        ""subStep"": ""closeResearchTree"",
            //        ""target"": """",
            //        ""type"": ""moduleUnloaded"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new TutorialStepsRequestData("CampaignService", "start", JArray.Parse(@"[]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""clickOnCampaignMap"",
            //        ""subStep"": ""openCampaignMap"",
            //        ""target"": ""HUD_CAMPAIGN_MAP_MENU_BUTTON"",
            //        ""type"": ""buttonClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""clickOnCampaignMap"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""clickOnCampaignMap"",
            //        ""subStep"": ""campaignMapLoaded"",
            //        ""target"": ""CAMPAIGN_MAP"",
            //        ""type"": ""moduleLoaded"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("CampaignService", "moveScoutToProvince", JArray.Parse(@"[[0,1],3]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""scoutProvince"",
            //        ""subStep"": ""scoutProvince"",
            //        ""target"": ""SCOUT_BUTTON"",
            //        ""type"": ""mouseClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""scoutProvince"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("CampaignService", "scout", JArray.Parse(@"[1]"))
            // },
            // new[]
            // {
            //     new FOERequestData("CampaignService", "getProvinceData", JArray.Parse(@"[1]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""enterProvince"",
            //        ""subStep"": ""clickProvince"",
            //        ""target"": ""PROVINCE"",
            //        ""type"": ""mouseClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""enterProvince"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""selectSector"",
            //        ""subStep"": ""clickSector"",
            //        ""target"": ""SECTOR"",
            //        ""type"": ""mouseClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("ArmyUnitManagementService", "getArmyInfo", 
            //         JArray.Parse(@"[{""__class__"":""ArmyContext"",""battleType"":""campaign""}]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""selectSector"",
            //        ""subStep"": ""clickAttackButton"",
            //        ""target"": ""ATTACK_SECTOR_ATTACK_BUTTON"",
            //        ""type"": ""buttonClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""selectSector"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""attackSector"",
            //        ""subStep"": ""clickFirstUnitIcon"",
            //        ""target"": """",
            //        ""type"": ""unitIconClicked"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""attackSector"",
            //        ""subStep"": ""clickSecondUnitIcon"",
            //        ""target"": """",
            //        ""type"": ""unitIconClicked"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("ArmyUnitManagementService", "updatePools", JArray.Parse(@"[
                    [{""__class__"":""ArmyPool"",""units"":[2049,1],""type"":""attacking""},
                    {""__class__"":""ArmyPool"",""units"":[],""type"":""defending""},
                    {""__class__"":""ArmyPool"",""units"":[],""type"":""arena_defending""}],
                    {""__class__"":""ArmyContext"",""battleType"":""campaign""}
               ]"))
            },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""attackSector"",
            //        ""subStep"": ""clickAttackButton"",
            //        ""target"": ""ARMY_MANAGEMENT_ATTACK_BUTTON"",
            //        ""type"": ""mouseClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""attackSector"", ""1.0.11"", ""battle""]"))
            },
            // new[]
            // {
            //     new FOERequestData("BattlefieldService", "startByBattleType", JArray.Parse(@"[
            //     {""__class__"":""CampaignBattleType"",
            //     ""attackerPlayerId"":0,""defenderPlayerId"":0,
            //     ""type"":""campaign"",
            //     ""currentWaveId"":0,
            //     ""totalWaves"":0,""provinceId"":1,
            //     ""sectorId"":1},false]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""battlefield"",
            //        ""target"": ""BATTLE"",
            //        ""type"": ""moduleLoaded"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""moveFirstUnit"",
            //        ""target"": ""BATTLEFIELD_HEX_MAP"",
            //        ""type"": ""battleCommandIssued"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("BattlefieldService", "submitMove", JArray.Parse(@"
            //         [381493955,{""__class__"":""BattleStep"",""unitId"":2,""path"":[{""__class__"":""Position"",""x"":1,""y"":7},
            //         {""__class__"":""Position"",""x"":2,""y"":7},{""__class__"":""Position"",""x"":3,""y"":7},
            //         {""__class__"":""Position"",""x"":4,""y"":6},{""__class__"":""Position"",""x"":5,""y"":6},
            //         {""__class__"":""Position"",""x"":6,""y"":6}],""attackedUnitId"":0,""dealtDamage"":0,""attackedUnitHitpoints"":0,""unitHitpoints"":0,
            //         ""receivedDamage"":0,""round"":0,""additionalStep"":false,""wasCriticalHit"":false,
            //         ""wasPoisoned"":false,""tookPoisonDamage"":false,""appliedAbilities"":null},0]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""enemyMoveFirstUnit"",
            //        ""target"": """",
            //        ""type"": ""enemyMoveFinished"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""unitTurnInfo"",
            //        ""target"": ""RAGU_BUBBLE"",
            //        ""type"": ""buttonClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""moveSecondUnit"",
            //        ""target"": ""BATTLEFIELD_HEX_MAP"",
            //        ""type"": ""battleCommandIssued"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("BattlefieldService", "submitMove", JArray.Parse(@"
            //         [381493955,{""__class__"":""BattleStep"",""unitId"":2050,""path"":[{""__class__"":""Position"",""x"":0,""y"":7},
            //         {""__class__"":""Position"",""x"":1,""y"":7},{""__class__"":""Position"",""x"":2,""y"":7},
            //         {""__class__"":""Position"",""x"":3,""y"":7},{""__class__"":""Position"",""x"":4,""y"":7}],
            //         ""attackedUnitId"":0,""dealtDamage"":0,""attackedUnitHitpoints"":0,""unitHitpoints"":0,""receivedDamage"":0,
            //         ""round"":0,""additionalStep"":false,""wasCriticalHit"":false,""wasPoisoned"":false,""tookPoisonDamage"":false,""appliedAbilities"":null},0]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""enemyMoveSecondUnit"",
            //        ""target"": """",
            //        ""type"": ""enemyMoveFinished"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""enemyMoveSecondUnit"",
            //        ""target"": """",
            //        ""type"": ""enemyMoveFinished"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("BattlefieldService", "submitMove", JArray.Parse(@"
            //         [381493955,{""__class__"":""BattleStep"",""unitId"":2,""path"":[{""__class__"":""Position"",""x"":6,""y"":7}],
            //         ""attackedUnitId"":-2,""dealtDamage"":0,""attackedUnitHitpoints"":0,""unitHitpoints"":0,""receivedDamage"":0,""round"":0,
            //         ""additionalStep"":false,""wasCriticalHit"":false,""wasPoisoned"":false,""tookPoisonDamage"":false,""appliedAbilities"":null},0]
            //         "))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""attackFirstEnemyUnit"",
            //        ""target"": ""BATTLEFIELD_HEX_MAP"",
            //        ""type"": ""battleCommandIssued"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""enemyUnitDied"",
            //        ""target"": """",
            //        ""type"": ""enemyUnitDied"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""attackSecondEnemyUnit"",
            //        ""target"": ""RAGU_BUBBLE"",
            //        ""type"": ""buttonClick"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            // new[]
            // {
            //     new FOERequestData("BattlefieldService", "submitMove", JArray.Parse(@"
            //     [381493955,{""__class__"":""BattleStep"",""unitId"":2050,""path"":[{""__class__"":""Position"",""x"":5,""y"":7},
            //     {""__class__"":""Position"",""x"":6,""y"":7},{""__class__"":""Position"",""x"":7,""y"":7}],""attackedUnitId"":-1,""dealtDamage"":0,
            //     ""attackedUnitHitpoints"":0,""unitHitpoints"":0,""receivedDamage"":0,""round"":0,""additionalStep"":false,""wasCriticalHit"":false,
            //     ""wasPoisoned"":false,""tookPoisonDamage"":false,""appliedAbilities"":null},0]"))
            // },
            // new[]
            // {
            //     new FOERequestData("TutorialService", "track", JArray.Parse(@"[
            //    {
            //        ""finishedStep"": true,
            //        ""stepId"": ""startBattle"",
            //        ""subStep"": ""battleFinished"",
            //        ""target"": """",
            //        ""type"": ""battleFinished"",
            //        ""version"": ""1.0.11"",
            //        ""__class__"": ""TutorialFlowTracking""
            //    }]"))
            // },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""startBattle"", ""1.0.11"", ""battle""]"))
            },
            new[]
            {
                new FOERequestData("TutorialService", "updateStep", JArray.Parse(@"[
                 ""end"", ""1.0.11"", ""battle""]"))
            },
            new[]
            {
                new FOERequestData("ResearchService", "spendForgePoints", JArray.Parse(@"[""pottery"",3]"))
            },
            // new[]
            // {
            //     new TutorialStepsRequestData("CampaignService", "start", JArray.Parse(@"[]"))
            // },
        };
    }
}