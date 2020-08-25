using System;
using static DataModels.Enums.ServiceReportEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportChecklistMappingFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long ReportChecklistId { get; set; }
        public long ChecklistId { get; set; }
        public string Description { get; set; }
        public ChecklistType ChecklistType { get; set; }
        public bool Action { get; set; }
    }
}