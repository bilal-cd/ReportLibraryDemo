using System;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportImageDetailFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long ReportId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}