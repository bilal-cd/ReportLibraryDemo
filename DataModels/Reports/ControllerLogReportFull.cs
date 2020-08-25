using System;
using System.Collections.Generic;

namespace DataModels.Reports
{
    [Serializable]
    public class ControllerLogReportFull
    {
        public string Status { get; set; }
        public Device Device { get; set; }
        public string Request { get; set; }
    }

    public class Device
    {
        public string Serial_number { get; set; }
        public string Name { get; set; }
        public string Account_number { get; set; }
        public string Client_name { get; set; }
        public string Physical_location { get; set; }
        public string Line_id { get; set; }
        public string Model_number { get; set; }
        public string Street_address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_code { get; set; }
        public string Firmware_version { get; set; }
        public List<System> Systems { get; set; }
    }

    public class System
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Active { get; set; }
        public List<Sensor> Sensors { get; set; }
    }

    public class Sensor
    {
        public int Number { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uom { get; set; }
        public List<Record> Records { get; set; }
    }

    public class Record
    {
        public DateTime Date { get; set; }
        public string Value { get; set; }
        public string Setpoint { get; set; }
        public string High_alarm { get; set; }
        public string Low_alarm { get; set; }
        public string Differential { get; set; }
    }
}
