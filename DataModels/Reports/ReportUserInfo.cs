using System;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportUserInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}