using System;
using static DataModels.Enums.ReportEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportAssignedUserFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long ReportId { get; set; }
        public UserAccessType ReportAccessType { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}