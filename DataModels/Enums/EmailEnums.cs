using System.ComponentModel;

namespace DataModels.Enums
{
    public class EmailEnums
    {
        public enum SentEmailType
        {
            [Description("None")]
            None=0,
            [Description("Auto Email On Submit")]
            OnSubmit=1,
            [Description("Manual Email")]
            Manual=2,
            [Description("Escalation Email")]
            EscalationEmail = 3
        }
    }
}
