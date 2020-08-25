using System;
using DataModels.Enums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportInventoryFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public decimal ContainerSize { get; set; }
        public decimal MinLevel { get; set; }
        public UnitOfMeasurementEnum UnitOfMeasurement { get; set; }
        public string UnitOfMeasurementValue { get; set; }
        public string PumpName { get; set; }
        public double? CurrentLevel { get; set; }
        public double? RefilledAmount { get; set; }
        public double? Daily { get; set; }
        public double? Weekly { get; set; }
        public double? Monthly { get; set; }
        public double? Yearly { get; set; }
        public string InventoryImage { get; set; }
        public string QuickPhrase { get; set; }
        public decimal? Stroke { get; set; }
        public decimal? Speed { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string PumpImage { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsActive { get; set; }
        public long? MasterInventoryId { get; set; }
        public long ReportId { get; set; }
    }
}