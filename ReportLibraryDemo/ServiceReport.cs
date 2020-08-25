namespace ReportLibraryDemo
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ServiceReport.
    /// </summary>
    public partial class ServiceReport : Telerik.Reporting.Report
    {
        public ServiceReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            DesignReport();
        }

        private void DesignReport()
        {
            pictureBox1.Value = @"C:\Users\Bilal\Desktop\Serial.png";
            address1.Value = @"6555 E Southern Ave";
            address2.Value = @"Mesa, AZ";
            address3.Value = @"85206";
            address4.Value = @"US";
            createdOn.Value = @"05-04-2020 11:27";
            createdBy.Value = @"Alan Smith";
            email.Value = @"alans@dynamicwater.com";
            reportName.Value =
                @"Service Report‐Macerich Superstition Springs Center‐Superstition Springs Center Cooling Tower‐1010‐05 04,2020‐11:27";
            reportStatus.Value = @"SUBMITTED";
            reportId.Value = @"1313123";

        }
    }
}