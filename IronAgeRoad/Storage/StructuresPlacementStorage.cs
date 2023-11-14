using CruelWorld.IronAgeRoad.Models;
using CruelWorld.IronAgeRoad.Models.Place;

namespace MyNameIsGiorgio.IronAgeRoad.Storage
{
    public class StructuresPlacementStorage
    {
        public int CurrentPlaceStep;

        public BuildingsToPlace[] buildingPositions = new[]
        {
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 8,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 9,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 10,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 11,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 12,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 13,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 14,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 16,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 17,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 18,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 19,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 20,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 21,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 10,
            //     y = 22,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 19,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 18,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 17,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 16,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 14,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 13,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 12,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 11,
            //     y = 15,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 16,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 17,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 18,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 19,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 20,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 21,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 15,
            //     y = 22,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 16,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 17,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 18,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 19,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 20,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 21,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 20,
            //     y = 22,
            //     cityentityId = "S_StoneAge_Street",
            //     type = "street",
            //     moneyCost = 0,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 8,
            //     y = 18,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 8,
            //     y = 20,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 8,
            //     y = 22,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 17,
            //     y = 19,
            //     cityentityId = "P_StoneAge_Hunter",
            //     type = "production",
            //     moneyCost = 96,
            //     suppliesCost = 0
            // },
            // new BuildingsToPlace()
            // {
            //     x = 21,
            //     y = 16,
            //     cityentityId = "P_BronzeAge_Pottery",
            //     type = "production",
            //     moneyCost = 240,
            //     suppliesCost = 30
            // },
            // new BuildingsToPlace()
            // {
            //     x = 21,
            //     y = 20,
            //     cityentityId = "P_BronzeAge_Pottery",
            //     type = "production",
            //     moneyCost = 240,
            //     suppliesCost = 30
            // },
            // new BuildingsToPlace()
            // {
            //     x = 19,
            //     y = 8,
            //     cityentityId = "D_StoneAge_Statue",
            //     type = "decoration",
            //     moneyCost = 20,
            //     suppliesCost = 20
            // },
            // new BuildingsToPlace()
            // {
            //     x = 21,
            //     y = 8,
            //     cityentityId = "D_StoneAge_Statue",
            //     type = "decoration",
            //     moneyCost = 20,
            //     suppliesCost = 20
            // },
            // new BuildingsToPlace()
            // {
            //     x = 17,
            //     y = 10,
            //     cityentityId = "D_StoneAge_Statue",
            //     type = "decoration",
            //     moneyCost = 20,
            //     suppliesCost = 20
            // },
            // new BuildingsToPlace()
            // {
            //     x = 19,
            //     y = 10,
            //     cityentityId = "D_StoneAge_Statue",
            //     type = "decoration",
            //     moneyCost = 20,
            //     suppliesCost = 20
            // },
            // new BuildingsToPlace()
            // {
            //     x = 21,
            //     y = 10,
            //     cityentityId = "D_StoneAge_Statue",
            //     type = "decoration",
            //     moneyCost = 20,
            //     suppliesCost = 20
            // },
            // new BuildingsToPlace()
            // {
            //     x = 11,
            //     y = 16,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 11,
            //     y = 18,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 11,
            //     y = 20,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 11,
            //     y = 22,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 13,
            //     y = 16,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 13,
            //     y = 18,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 13,
            //     y = 20,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 13,
            //     y = 22,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 17,
            //     y = 13,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            // new BuildingsToPlace()
            // {
            //     x = 19,
            //     y = 13,
            //     cityentityId = "R_StoneAge_Residential",
            //     type = "residential",
            //     moneyCost = 0,
            //     suppliesCost = 60
            // },
            new BuildingsToPlace()
            {
                x = 20,
                y = 16,
                cityentityId = "P_BronzeAge_Pottery",
                type = "production",
                moneyCost = 240,
                suppliesCost = 30
            },
            new BuildingsToPlace()
            {
                x = 8,
                y = 22,
                cityentityId = "D_StoneAge_Statue",
                type = "decoration",
                moneyCost = 20,
                suppliesCost = 20
            },
        };
    }
}