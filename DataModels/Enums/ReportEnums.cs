using System.ComponentModel;

namespace DataModels.Enums
{
    public class ReportEnums
    {
        public enum ReportType
        {
            [Description("Service Report")]
            Service = 1,
            [Description("Coupon Report")]
            Coupon = 2,
            [Description("Note Report")]
            Note = 3,
            [Description("Log Report")]
            Log = 4,
            [Description("Legoinella Report")]
            Legoinella = 5
        }

        public enum UserAccessType
        {
            [Description("None")]
            None = 0,
            [Description("Collected By")]
            CollectedBy = 1,
            [Description("Escalated")]
            Escalated = 2
        }
        public enum CouponUnitOfMeasurement
        {
            [Description("None")]
            None=0,
            [Description("mils per year(mps)")]
            Mps = 1,
            [Description("inchesper year(ipy)")]
            Ipy = 2,
            [Description("inches per month(ipm)")]
            Ipm = 3,
            [Description("milimeters per year(mm/y)")]
            Mmy = 4,
            [Description("micrometers per second(um/s)")]
            Umy = 5,
            [Description("picometers per second(pm/s)")]
            Pmy = 6,
            [Description("grams per sqaure meter per hour(g/m^z-h)")]
            Gsm = 7,
            [Description("miligrams per sqaure decimeter per day(mdd)")]
            Mdd = 8
        }

        public enum DaysFilter
        {
            [Description("All")]
            All = 0,
            [Description("30 Days")]
            Days30 = 1,
            [Description("90 Days")]
            Days90 = 2,
            [Description("180 Days")]
            Days180 = 3,
            [Description("text-red")]
            Year = 4
        }
        public enum CellColor
        {
            [Description("text-white")]
            White = 0,
            [Description("text-green")]
            Green = 1,
            [Description("text-yellow")]
            Yellow = 2,
            [Description("text-red")]
            Red = 3,
            [Description("text-grey")]
            Gray = 4
        }
    }
}
