using System;
using System.Collections.Generic;
using static DataModels.Enums.ReportEnums;
using static DataModels.Enums.ServiceReportEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportFull
    {
        public int TenantId { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? SampleCollected { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int? LabId { get; set; }
        public long? UserId { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string Mileage { get; set; }
        public int? WorkOrderNo { get; set; }
        public ReportStatusEnum Status { get; set; }
        public ReportType ReportType { get; set; }
        public string StatusValue { get; set; }
        public long? ReportTemplateId { get; set; }
        public long? UnitId { get; set; }
        public string CompanyUnitName { get; set; }
        public string ContactNo { get; set; }
        public string Attention { get; set; }
        public string RecorderName { get; set; }
        public string RecorderEmail { get; set; }
        public string RecorderPhone { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public List<ReportDetailFull> ReportDetails { get; set; }
        public List<ReportInventoryFull> ReportInventory { get; set; }
        public List<ReportWaterMeterFull> ReportWaterMeters { get; set; }
        public List<ReportEquipmentFull> ReportEquipments { get; set; }
        public List<ReportImageDetailFull> ReportImageDetails { get; set; }
        public List<ReportAssignedUserFull> ReportAssignedUsers { get; set; }
    }
}
