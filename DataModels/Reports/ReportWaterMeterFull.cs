using System;
using static DataModels.Enums.WaterMeterEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportWaterMeterFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public WaterMeterUnitOfMeasureEnum UnitOfMeasure { get; set; }
        public string UnitOfMeasureValue { get; set; }
        public double? CurrentReading { get; set; }
        public double? Daily { get; set; }
        public double? Weekly { get; set; }
        public double? Monthly { get; set; }
        public double? Yearly { get; set; }
        public string Image { get; set; }
        public long? MasterWaterMeterId { get; set; }
        public long ReportId { get; set; }
    }
}