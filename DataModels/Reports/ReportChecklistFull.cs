using System;
using System.Collections.Generic;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportChecklistFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long ReportId { get; set; }
        public string Comment { get; set; }
        public List<ReportChecklistMappingFull> ReportChecklistMapping { get; set; }
    }
}