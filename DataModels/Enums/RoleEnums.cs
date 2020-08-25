using System.ComponentModel;

namespace DataModels.Enums
{
    public class RoleEnums
    {
        public enum RoleAccessType
        {
            [Description("None")]
            None = 0,
            [Description("Full")]
            Full = 1,
            [Description("ViewOnly")]
            View = 2
        }
        public enum PageAccess
        {
            [Description("None")]
            None =0,
            [Description("Tenants")]
            Tenants =1,
            [Description("Users")]
            Users =2,
            [Description("Roles")]
            Roles = 3,
            [Description("MTest")]
            MTest = 4,
            [Description("Customer")]
            Customer = 5,
            [Description("Customer Group")]
            CustomerGroup = 6,
            [Description("Panel")]
            Panel = 7,
            [Description("Product")]
            Product = 8,
            [Description("Panel Test")]
            PanelTest = 9,
            [Description("Pump")]
            Pump = 10,
            [Description("File")]
            File = 11,
            [Description("Water Meter")]
            WaterMeter = 12,
            [Description("Controller")]
            Controller = 13,
            [Description("Product Pump")]
            ProductPump = 14,
            [Description("Units")]
            Units = 15,
            [Description("Report Templates")]
            ReportTemplates = 16,
            [Description("Service Report")]
            ServiceReport = 17,
            [Description("Checklist")]
            Checklist = 18,
            [Description("Quick Phrase")]
            QuickPhrase = 19,
            [Description("Quick Phrase Category")]
            QuickPhraseCategory = 20,
            [Description("Email Schedules")]
            EmailSchedules = 21,
            [Description("Coupon Types")]
            CouponTypes = 22,
            [Description("Email Log")]
            EmailLog = 23,
            [Description("Dashboard")]
            Dashboard = 24
        }
    }
}
