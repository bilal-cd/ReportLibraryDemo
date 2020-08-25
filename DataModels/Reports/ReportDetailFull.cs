using System;
using static DataModels.Enums.ReportEnums;
using static DataModels.Enums.TestEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportDetailFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long ReportTemplateId { get; set; }
        public long ReportId { get; set; }
        public long? CouponId { get; set; }
        public string CouponName { get; set; }
        public string CouponType { get; set; }
        public decimal? CouponDensity { get; set; }
        public string Location { get; set; }
        public decimal? WeightIn { get; set; }
        public decimal? WeightOut { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public OutputFormatsEnum OutputFormat { get; set; }
        public string OutputFormatValue { get; set; }
        public decimal? Result { get; set; }
        public string ResultLegionella { get; set; }
        public string SampleDescription { get; set; }
        public string ControlRange { get; set; }
        public long? PanelId { get; set; }
        public string PanelName { get; set; }
        public string StereoType { get; set; }
        public long? MTestId { get; set; }
        public string MTestName { get; set; }
        public TestTypesEnum TestType { get; set; }
        public long? ReportTemplateDetailId { get; set; }
        public TestLabelEnum TestLabel { get; set; }
        public string TestLabelValue { get; set; }
        public string DateValue { get; set; }
        public DateTime? Date { get; set; }
        public string TestTypeValue { get; set; }
        public decimal? InputRange { get; set; }
        public CellColor Color { get; set; }
        public string ColorValue { get; set; }
        public string Expression { get; set; }
        public string QuickPhrase { get; set; }
        public decimal? HighWarningAlarm { get; set; }
        public decimal? HighAlarm { get; set; }
        public decimal? HighControl { get; set; }
        public decimal? LowControl { get; set; }
        public decimal? LowAlarm { get; set; }
        public decimal? LowWarningAlarm { get; set; }
        public bool IsFromTemplate { get; set; }
        public bool IsFromReport { get; set; }
        public bool IsDisable { get; set; }
        public string Label { get; set; }
    }
}
