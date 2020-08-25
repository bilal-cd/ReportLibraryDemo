using System;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportEquipmentFull
    {
        public long Id { get; set; }
        public int TenantId { get; set; }
        public long? EquipmentId { get; set; }
        public long ReportId { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
    }
}