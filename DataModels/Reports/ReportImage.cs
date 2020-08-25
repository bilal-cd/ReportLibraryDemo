using System;
using static DataModels.Enums.FileEnums;

namespace DataModels.Reports
{
    [Serializable]
    public class ReportImage
    {
        public FeatureEnum FeatureType { get; set; }
        public string Url { get; set; }
    }
}