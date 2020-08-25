using System;
using System.IO;
using ReportLibraryDemo;
using Telerik.Reporting.Processing;

namespace ReportDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Report Started!");
            //Report1 report= new Report1();
            //ReportProcessor reportProcessor = new ReportProcessor();
            //Telerik.Reporting.InstanceReportSource instanceReportSource = new Telerik.Reporting.InstanceReportSource();
            //instanceReportSource.ReportDocument = report;
            //RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            //using (FileStream fs = new FileStream("DemoFile", FileMode.Create))
            //{
            //    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            //}

            Console.WriteLine("Report Ended!");
        }
    }
}
