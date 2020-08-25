using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using DataModels.Reports;
using ReportLibraryDemo;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
            ReportRangesFull obj = new ReportRangesFull
            {
                MTestName = "pH",
                HighAlarm = 200
            };

            ReportRangesFull obj1 = new ReportRangesFull
            {
                MTestName = "pH",
                HighAlarm = 200
            };
            ReportRangesFull obj2 = new ReportRangesFull
            {
                MTestName = "pH",
                HighAlarm = 200
            };

            var lst = new List<ReportRangesFull> {obj, obj1, obj2};

            TestObjectDataSource objReport = new TestObjectDataSource();
            objReport.DataSource = lst;


            //objReport

            //var reportSource = new Telerik.Reporting.InstanceReportSource();
            ////var reportSource = new Telerik.Reporting.TypeReportSource();
            //reportSource.ReportDocument = objReport;
            //reportSource.ReportDocument.DocumentName = "ReportLibraryDemo.Report1, ReportLibraryDemo, Version=14.1.20.618, Culture=neutral, PublicKeyToken=null";
            ExportToPDF(objReport);

            //objReport.

        }
        public static void ExportToPDF(Telerik.Reporting.Report reportToExport)
        {
            ReportProcessor reportProcessor = new ReportProcessor();
            //Telerik.Reporting.InstanceReportSource instanceReportSource = new Telerik.Reporting.InstanceReportSource();
            //instanceReportSource.ReportDocument = reportToExport;
            RenderingResult result = reportProcessor.RenderReport("PDF", reportToExport, null);

            

            string fileName = result.DocumentName+ DateTime.Now.Ticks + "." + result.Extension;


            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;

            string projectPath = directoryInfo.FullName;
            string folderName = Path.Combine(projectPath, "TestDataSource");
            if (!Directory.Exists(folderName))
            { Directory.CreateDirectory(folderName); }

            string filePath = Path.Combine(folderName, fileName);

            using (FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
            //Response.Clear();
            //Response.ContentType = result.MimeType;
            //Response.Cache.SetCacheability(HttpCacheability.Private);
            //Response.Expires = -1;
            //Response.Buffer = true;

            //Response.AddHeader("Content-Disposition",
            //    string.Format("{0};FileName=\"{1}\"",
            //        "attachment",
            //        fileName));

            //Response.BinaryWrite(result.DocumentBytes);
            //Response.End();
        }
    }
}
