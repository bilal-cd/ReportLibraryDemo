using System.ComponentModel;

namespace DataModels.Enums
{
    public class FileEnums
    {
        public enum FeatureEnum
        {
            [Description("Product")]
            Product = 1,
            [Description("Panel")]
            Panel = 2,
            [Description("PDS")]
            Pds = 3,
            [Description("SDS")]
            Sds = 4,
            [Description("Pump")]
            Pump = 5,
            [Description("Profile")]
            Profile = 6,
            [Description("Report Cell Notes")]
            ReportCellNotes = 7,
            [Description("Report Inventory")]
            ReportInventory = 8,
            [Description("Report Pump")]
            ReportPump = 9,
            [Description("Report WaterMeter")]
            ReportWaterMeter = 10,
            [Description("Report Main")]
            ReportMain = 11,
            [Description("General Signature")]
            GeneralSignature = 12,
            [Description("Operator Signature")]
            OperatorSignature = 13,
            [Description("Service Rep.")]
            ServiceRep = 14,
            [Description("Manager Signature")]
            ManagerSignature = 15,
            [Description("Report Profile")]
            ReportProfile = 16,
            [Description("Customer Image")]
            CustomerImage = 17,
            [Description("Training Material")]
            TrainingMaterial = 18,
            [Description("YouTube Videos")]
            YouTubeVideos = 19,
            [Description("Logos")]
            Logos = 20
        }
        public enum FileExtensionEnum
        {
            [Description("Image")]
            Image =1,
            [Description("PDF")]
            Pdf =2,
            [Description("Txt")]
            Text =3,
            [Description("Xlsx")]
            Sheet = 4,
            [Description("Link")]
            Link = 5
        }

    }
}
