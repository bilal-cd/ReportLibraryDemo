using System.ComponentModel;

namespace DataModels.Enums
{
    public class ServiceReportEnums
    {
        public enum ReportStatusEnum
        {
            [Description("None")]
            None =0,
            [Description("Submitted")]
            Submitted =1,
            [Description("Saved Draft")]
            SavedDraft = 2,
            [Description("Auto-Saved Draft")]
            AutoSavedDraft=3,
            [Description("Approved")]
            Approved =4
        }

        public enum ChecklistType
        {
            None=0,
            Checklist=1,
            Custom=2
        }
    }
}
