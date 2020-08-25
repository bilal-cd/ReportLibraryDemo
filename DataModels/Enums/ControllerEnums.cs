using System.ComponentModel;

namespace DataModels.Enums
{
    public class ControllerEnums
    {
        public enum ManufacturersEnum
        {
            [Description("Advantage Controls")]
            AdvantageControls = 1,
            [Description("Walchem")]
            Walchem =2,
            [Description("Lakewood")]
            Lakewood =3,
            [Description("Prominent")]
            Prominent =4
        }
    }
}
