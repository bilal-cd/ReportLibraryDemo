using System;
using System.Collections.Generic;
using static DataModels.Enums.EmailEnums;
using static DataModels.Enums.ReportEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportDetail
    {
        public int TenantId { get; set; }
        public long Id { get; set; }
        public long? ReportTemplateId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public long? UserId { get; set; }
        public long? UnitId { get; set; }
        public int? WorkOrderNo { get; set; }
        public string UserName { get; set; }
        public string Mileage { get; set; }
        public ReportType ReportType { get; set; }
        public string ReportTypeValue { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public bool IsImageExist { get; set; }
        public bool IsSignatureExist { get; set; }
        public bool IsEmailSent { get; set; }
        public List<EmailDetail> ReportEmailDetails { get; set; }
    }

    public class EmailDetail
    {
        public string SentBy { get; set; }
        public long? SenderId { get; set; }
        public DateTime SentDate { get; set; }
        public string SentTo { get; set; }
        public SentEmailType EmailType { get; set; }
        public string EmailTypeValue { get; set; }

    }
}