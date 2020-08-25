using System.ComponentModel;

namespace DataModels.Enums
{
    public class TestEnums
    {
        public enum TestTypesEnum
        {
            Basic = 1,
            Fixed = 2,
            Calculated = 3
        }

        public enum OutputFormatsEnum
        {
            [Description("0")]
            OnlyZero = 1,
            [Description("0.0")]
            OneDecimal = 2,
            [Description("0.00")]
            TwoDecimal = 3,
            [Description("0.000")]
            ThreeDecimal = 4,
            [Description("0.0000")]
            FourDecimal = 5,
            [Description("0%")]
            Percentage = 6,
            [Description("0.0%")]
            PercentageWithDecimal = 7
        }

        public enum TestLabelEnum
        {
            [Description("None")]
            None = 0,
            [Description("Record")]
            Record =1,
            [Description("Cycles")]
            Cycles =2,
            [Description("High")]
            High =3,
            [Description("Low")]
            Low =4,
            [Description("MAX")]
            Max =5,
            [Description("MIN")]
            Min =6,
            [Description("MGL")]
            Mgl =7,
            [Description("mV")]
            Mv =8,
            [Description("Mhos")]
            Mhos =9,
            [Description("mmhos")]
            Mmhos =10,
            [Description("Normal")]
            Normal =11,
            [Description("ohm")]
            Ohm =12,
            [Description("PPB")]
            Ppb =13,
            [Description("PPM")]
            Ppm =14,
            [Description("umhos")]
            Umhos = 15,
            [Description("°F")]
            Fahrenheit = 16,
            [Description("°C")]
            Celcius = 17,
            [Description("µS")]
            MicroS =18,
            [Description("CFU")]
            Cfu =19,
            [Description("su")]
            su =20,
            [Description("µS/cm")]
            MicroSPerCm =21,
            [Description("PSI")]
            Psi =22,
            [Description("BAR")]
            Bar =23,
            [Description("MΩ")]
            MΩ =24,
            [Description("mg/l")]
            MgPerl =25,
            [Description("%")]
            Percent =26,
            [Description("GPM")]
            Gpm =27,
            [Description("kgal")]
            Kgal =28,
            [Description("lbs/day")]
            LbsPerDay =29,
            [Description("GPD")]
            Gpd =30,
            [Description("RLU")]
            Rlu =31,
            [Description("kLbs/hr")]
            KLbsPerHr =32
        }
    }
}