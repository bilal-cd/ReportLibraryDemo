using System;
using static DataModels.Enums.ServiceReportEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportChecklistDetail
    {
        public long ReportTemplateId { get; set; }
        public long ChecklistId { get; set; }
        public string Description { get; set; }
        public ChecklistType ChecklistType { get; set; }
    }
}
