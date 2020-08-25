using DataModels.Reports;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Telerik.Reporting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reportViewer1.ReportSource.Parameters
                .Add(new Parameter( "reportFull", new ReportFull{StatusValue = "string"}));
            reportViewer1.RefreshReport();
            RenderReport();
        }

        public static void RenderReport()
        {
            var reportProcessor = new Telerik.Reporting.Processing.ReportProcessor();
            var deviceInfo = new Hashtable();

            // Depending on the report definition choose ONE of the following REPORT SOURCES
            //                  -1-
            // ***CLR (CSharp) report definitions***
            var reportSource = new Telerik.Reporting.TypeReportSource();

            // reportName is the Assembly Qualified Name of the report
            reportSource.TypeName = "ReportLibraryDemo.Report1, ReportLibraryDemo, Version=14.1.20.618, Culture=neutral, PublicKeyToken=null";
            //                  -1-

            ////                  -2-
            //// ***Declarative (TRDP/TRDX) report definitions***
            //var reportSource = new Telerik.Reporting.UriReportSource();

            //// reportName is the path to the TRDP/TRDX file
            //reportSource.Uri = reportName;
            ////                  -2-

            ////                  -3-
            //// ***Instance of the report definition***
            //var reportSource = new Telerik.Reporting.InstanceReportSource();

            //// Report1 is the class of the report. It should inherit Telerik.Reporting.Report class
            //reportSource.ReportDocument = new Report1();
            ////                  -3-

            // Pass parameter value with the Report Source if necessary
            //object parameterValue = "Some Parameter Value";
            //reportSource.Parameters.Add("ParameterName", parameterValue);

            Telerik.Reporting.Processing.RenderingResult result = reportProcessor.RenderReport("PDF", reportSource, deviceInfo);

            string fileName = result.DocumentName + "." + result.Extension;
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;

            string projectPath = directoryInfo.FullName;
            string folderName = Path.Combine(projectPath, "Reports");
            if (!Directory.Exists(folderName))
            { Directory.CreateDirectory(folderName); }

            string filePath = Path.Combine(folderName, fileName);

            using (FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }
    }
}
