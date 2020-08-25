using System.ComponentModel;

namespace DataModels.Enums
{
    public class WaterMeterEnums
    {
        public enum WaterMeterMeasureTypeEnum
        {
            [Description("None")]
            None = 0,
            [Description("Paddlewheel")]
            PaddleWheel = 1,
            [Description("Ultrasonic")]
            Ultrasonic = 2,
            [Description("Pulse")]
            Pulse = 3
        }

        public enum WaterMeterUnitOfMeasureEnum
        {
            [Description("None")]
            None = 0,
            [Description("Gal")]
            Gal=1,
            [Description("L")]
            L =2,
            [Description("qt")]
            Qt =3,
            [Description("pt")]
            Pt =4
        }
    }
}
