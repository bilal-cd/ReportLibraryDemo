using System.ComponentModel;
namespace DataModels.Enums
{
    public class TimeZones
    {
        public enum TimeZoneEnums
        {
            [Description("None")]
            None=0,
            [Description("Greenwich Mean Time (GMT)")]
            One = 1,
            [Description("Universal Coordinated Time (GMT)")]
            Two = 2,
            [Description("European Central Time (GMT+1:00) ")]
            Three = 3,
            [Description("Eastern European Time (GMT+2:00)")]
            Four = 4,
            [Description("(Arabic) Egypt Standard Time (GMT+2:00)")]
            Five = 5,
            [Description("Eastern African Time (GMT+3:00)")]
            Six = 6,
            [Description("Middle East Time (GMT+3:30)")]
            Seven = 7,
            [Description("Near East Time (GMT+4:00)")]
            Eight = 8,
            [Description("Pakistan Lahore Time (GMT+5:00)")]
            Nine = 9,
            [Description("India Standard Time (GMT+5:00)")]
            Ten = 10,
            [Description("Bangladesh Standard Time (GMT+6:00)")]
            Eleven = 11,
            [Description("Vietnam Standard Time (GMT+7:00)")]
            Twelve = 12,
            [Description("China Taiwan Time (GMT+8:00)")]
            Thirteen = 13,
            [Description("Japan Standard Time (GMT+9:00)")]
            Fourteen = 14,
            [Description("Australia Central Time (GMT+9:30)")]
            Fifteen = 15,
            [Description("Australia Eastern Time (GMT+10:00)")]
            Sixteen = 16,
            [Description("Solomon Standard Time (GMT+11:00)")]
            Seventeen = 17,
            [Description("New Zealand Standard Time (GMT+12:00)")]
            Eighteen = 18,
            [Description("Midway Islands Time (GMT-11:00)")]
            Nineteen = 19,
            [Description("Hawaii Standard Time (GMT-10:00)")]
            Twenty = 20,
            [Description("Alaska Standard Time (GMT-9:00)")]
            TwentyOne = 21,
            [Description("Pacific Standard Time (GMT-8:00)")]
            TwentyTwo = 22,
            [Description("Phoenix Standard Time (GMT-7:00)")]
            TwentyThree = 23,
            [Description("Mountain Standard Time (GMT-7:00)")]
            TwentyFour = 24,
            [Description("Central Standard Time (GMT-7:00)")]
            TwentyFive = 25,
            [Description("Eastern Standard Time (GMT-5:00)")]
            TwentySix = 26,
            [Description("Indiana Eastern Standard Time (GMT-5:00)")]
            TwentySeven = 27,
            [Description("Puerto Rico and US Virgin Islands Time (GMT-4:00)")]
            TwentyEight = 28,
            [Description("Canada Newfoundland Time (GMT-3:30)")]
            TwentyNine = 29,
            [Description("Argentina Standard Time (GMT-3:00)")]
            Thirty = 30,
            [Description("Brazil Eastern Time (GMT-3:00)")]
            ThirtyOne = 31,
            [Description("Central African Time (GMT-1:00)")]
            ThirtyTwo = 32
        }
    }
}