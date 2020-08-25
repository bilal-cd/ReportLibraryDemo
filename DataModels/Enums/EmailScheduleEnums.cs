using System.ComponentModel;

namespace DataModels.Enums
{
    public class EmailScheduleEnums
    {
        public enum ScheduleRange
        {
            [Description("None")]
            None = 0,
            [Description("Current Date")]
            CurrentDate = 1,
            [Description("Last 7 Days")]
            Last7 = 2,
            [Description("Last 30 Days")]
            Last30 = 3,
            [Description("Last 90 Days")]
            Last90 = 4,
            [Description("Last 180 Days")]
            Last180 = 5,
            [Description("Last Year")]
            LastYear = 6
        }

        public enum EmailType
        {
            None=0,
            Escalation=1,
            Approval=2,
            Rejection=3,
            Alerts=4,
            Normal=5,
            CorrosionCoupon=6
        }

        public enum ScheduleType
        {
            [Description("None")]
            None = 0,
            [Description("Weekly")]
            Weekly = 1,
            [Description("Monthly")]
            Monthly = 2,
        }

        public enum ScheduleDay
        {
            [Description("None")]
            None = 0,
            [Description("Monday")]
            Monday = 1,
            [Description("Tuesday")]
            Tuesday = 2,
            [Description("Wednesday")]
            Wednesday = 3,
            [Description("Thursday")]
            Thursday = 4, 
            [Description("Friday")]
            Friday = 5,
            [Description("Saturday")]
            Saturday = 6,
            [Description("Sunday")]
            Sunday = 7
        }

        public enum ScheduleUserType
        {
            [Description("None")]
            None = 0,
            [Description("User")]
            User = 1,
            [Description("Receiver")]
            Receiver = 2,
        }
    }
}
