using System.ComponentModel;

namespace DataModels.Enums
{
    public class UserEnums
    {
        public enum UserStatusEnum
        {
            [Description("InComplete")]
            InComplete = 1,
            [Description("Complete")]
            Complete = 2
        }
    }
}
