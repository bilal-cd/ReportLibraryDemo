using System.ComponentModel;

namespace DataModels.Enums
{
    public class CouponTypeEnums
    {
        public enum CouponCategory
        {
            [Description("None")]
            None = 0,
            [Description("Alloy Steel (Boiler)")]
            AlloySteelBoiler=1,
            [Description("Alloy Steel (Closed Loop System)")]
            AlloySteelClosedLoop =2,
            [Description("Alloy Steel (Condensate)")]
            AlloySteelCondensate = 3,
            [Description("Alloy Steel (Cooling Tower)")]
            AlloySteelCoolingTower = 4,
            [Description("Aluminum (Boiler)")]
            AluminumBoiler = 5,
            [Description("Aluminum (Closed Loop System)")]
            AluminumClosedLoop = 6,
            [Description("Aluminum (Condensate)")]
            AluminumCondensate = 7,
            [Description("Aluminum (Cooling Tower)")]
            AluminumCoolingTower = 8,
            [Description("Carbon Steel (Boiler)")]
            CarbonSteelBoiler = 9,
            [Description("Carbon Steel (Closed Loop System)")]
            CarbonSteelClosedLoop = 10,
            [Description("Carbon Steel (Condensate)")]
            CarbonSteelCondensate = 11,
            [Description("Carbon Steel (Cooling Tower)")]
            CarbonSteelCoolingTower = 12,
            [Description("Copper (Boiler)")]
            CopperBoiler = 13,
            [Description("Copper (Closed Loop System)")]
            CopperClosedLoop = 14,
            [Description("Copper (Condensate)")]
            CopperCondensate = 15,
            [Description("Copper (Cooling Tower)")]
            CopperCoolingTower = 16,
            [Description("Magnesium (Boiler)")]
            MagnesiumBoiler = 17,
            [Description("Magnesium (Closed Loop System)")]
            MagnesiumClosedLoop = 18,
            [Description("Magnesium (Condensate)")]
            MagnesiumCondensate = 19,
            [Description("Magnesium (Cooling Tower)")]
            MagnesiumCoolingTower = 20,
            [Description("Nickel (Boiler)")]
            NickelBoiler = 21,
            [Description("Nickel (Closed Loop System)")]
            NickelClosedLoop = 22,
            [Description("Nickel (Condensate)")]
            NickelCondensate = 23,
            [Description("Nickel (Cooling Tower)")]
            NickelCoolingTower = 24,
            [Description("Stainless Steel (Boiler)")]
            StainlessSteelBoiler = 25,
            [Description("Stainless Steel (Closed Loop System)")]
            StainlessSteelClosedLoop = 26,
            [Description("Stainless Steel (Condensate)")]
            StainlessSteelCondensate = 27,
            [Description("Stainless Steel (Cooling Tower)")]
            StainlessSteelCoolingTower = 28
        }
    }
}
