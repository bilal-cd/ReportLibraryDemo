using System.ComponentModel;

namespace DataModels.Enums
{
    public enum UnitOfMeasurementEnum
    {
        [Description("fl oz")]
        Floz=1,
        [Description("pt")]
        Pt =2,
        [Description("qt")]
        Qt =3,
        [Description("gal")]
        Gal =4,
        [Description("oz")]
        Oz =5,
        [Description("lb")]
        Lb =6,
        [Description("FT")]
        Ft =7,
        [Description("mg")]
        Mg =8,
        [Description("g")]
        G =9,
        [Description("kg")]
        Kg =10,
        [Description("t")]
        T =11,
        [Description("L")]
        L =12,
        [Description("%")]
        Percent =13,
        [Description("Drum (55gal)")]
        Drum =14,
        [Description("Tote (275gal)")]
        Tote =15,
        [Description("Units")]
        Units =16
    }

    public enum ContainerTypeEnum
    {
        [Description("Drum (55 gal)")] 
        Drum55 = 1,
        [Description("Drum (35 gal)")]
        Drum35 = 2,
        [Description("Drum (15 gal)")]
        Drum15 = 3,
        [Description("Tote (275 gal)")]
        Tote275 = 4,
        [Description("Pail (5 gal)")]
        Pail5 = 5
    }

}
