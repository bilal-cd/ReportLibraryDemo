using System;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportOwnerDetail
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ReportName { get; set; }
        public long UnitId { get; set; }
        public string UnitName { get; set; }
        public string UnitAddress { get; set; }
        public string ContactNo { get; set; }
        public string Attention { get; set; }
        public ReportUserInfo UserInfo { get; set; }
    }
}
