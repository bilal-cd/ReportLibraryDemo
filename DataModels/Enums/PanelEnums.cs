using System.ComponentModel;

namespace DataModels.Enums
{
    public class PanelEnums
    {
        public enum StereoTypesEnum
        {
            [Description("Boiler")]
            Boiler =1,
            [Description("Cooling Tower")]
            CoolingTower =2,
            [Description("R.O.")]
            Ro =3,
            [Description("Feed Water")]
            FeedWater =4,
            [Description("Raw Water")]
            RawWater =5,
            [Description("D.A.")]
            Da =6,
            [Description("Closed Loop")]
            ClosedLoop =7,
            [Description("Hot Loop")]
            HotLoop =8,
            [Description("Chilled Loop")]
            ChilledLoop =9
        }

        public enum EntityTypeEnum
        {
            Panel=1,
            ReportTemplate=2,
            Report=3
        }
    }
}
