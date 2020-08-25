using System.ComponentModel;

namespace DataModels.Enums
{
    public class ReportTemplateEnums
    {
        public enum ReportTemplateType
        {
            [Description("Service Report Template")]
            Service = 1,
            [Description("Coupon Report Template")]
            Coupon = 2,
            [Description("Note Report Template")]
            Note = 3,
            [Description("Log Report Template")]
            Log = 4
        }

        public enum ReportTemplateUserAccessType
        {
            [Description("Template Access")]
            Access = 1,
            [Description("Email On Submit")]
            EmailOnSubmit = 2,
            [Description("Escalation Recipients")]
            Escalation = 3,
            [Description("Required Approval")]
            Approval = 4,
            [Description("Sent InComplete Report")]
            SentInCompleteReport = 5,
            [Description("Collected By")]
            CollectedBy = 5
        }

        public enum MonthNameEnum
        {
            [Description("January")]
            January = 1,
            [Description("February")]
            February = 2,
            [Description("March")]
            March = 3,
            [Description("April")]
            April = 4,
            [Description("May")]
            May = 5,
            [Description("June")]
            June = 6,
            [Description("July")]
            July = 7,
            [Description("August")]
            August = 8,
            [Description("Spetember")]
            September = 9,
            [Description("October")]
            October = 10,
            [Description("November")]
            November = 11,
            [Description("December")]
            December = 12
        }
    }
}
