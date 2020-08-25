using System;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportRangesFull
    {
        public long ReportId { get; set; }
        public long ReportTemplateId { get; set; }
        public int HighWarningAlarm { get; set; }
        public int HighAlarm { get; set; }
        public int HighControl { get; set; }
        public int LowControl { get; set; }
        public int LowAlarm { get; set; }
        public long MTestId { get; set; }
        public string MTestName { get; set; }
        public int LowWarningAlarm { get; set; }
    }
}