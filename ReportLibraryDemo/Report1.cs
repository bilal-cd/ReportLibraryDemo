using System.Data;
using System.Drawing;
using DataModels.Reports;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace ReportLibraryDemo
{
    /// <summary>
	/// Summary description for Report1
	/// </summary>
    public partial class Report1 : Telerik.Reporting.Report
	{
		public Report1()
		{
            InitializeComponent();
            if(Report.ReportParameters.Count>0)
            {
                var reportObject = (ReportFull) Report.ReportParameters["reportFull"].Value;
            }
            DesignReport();
        }

        private void DesignReport()
        {
            //get the processing table object since we're in the context of event
            //construct the select statement based on the selected report parameters

            DataSet ds = new DataSet();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Column1", typeof(int));
            dataTable.Columns.Add("Column2", typeof(int));
            dataTable.Columns.Add("Column3", typeof(int));
            dataTable.Rows.Add(1, 2, 3);
            dataTable.Rows.Add(14, 23, 32);
            dataTable.Rows.Add(12, 24, 34);
            ds.Tables.Add(dataTable);
            table1.DataSource = ds.Tables[0];

            //create two HtmlTextBox items (one for header and one for data) which would be added to the items collection of the table
            HtmlTextBox textboxGroup;
            HtmlTextBox textBoxTable;

            //we do not clear the Rows collection, since we have a details row group and need to create columns only
            table1.ColumnGroups.Clear();
            table1.Body.Columns.Clear();
            table1.Body.Rows.Clear();
            int i = 0;
            table1.ColumnHeadersPrintOnEveryPage = true;
            foreach (System.Data.DataColumn dc in ds.Tables[0].Columns)
            {
                TableGroup tableGroupColumn = new TableGroup();
                table1.ColumnGroups.Add(tableGroupColumn);
                table1.Body.Columns.Add(new TableBodyColumn(Unit.Inch(1)));

                textboxGroup = new HtmlTextBox();
                textboxGroup.Style.BorderColor.Default = Color.Black;
                textboxGroup.Style.BorderStyle.Default = BorderType.Solid;
                textboxGroup.Value = dc.ColumnName;
                textboxGroup.Size = new SizeU(Unit.Inch(1.1), Unit.Inch(0.3));
                tableGroupColumn.ReportItem = textboxGroup;

                textBoxTable = new HtmlTextBox();
                textBoxTable.Style.BorderColor.Default = Color.Black;
                textBoxTable.Style.BorderStyle.Default = BorderType.Solid;
                textBoxTable.Value = @"=Fields." + dc.ColumnName;
                textBoxTable.Size = new SizeU(Unit.Inch(1.1), Unit.Inch(0.3));
                this.table1.Body.SetCellContent(0, i++, textBoxTable);
                this.table1.Items.AddRange(new ReportItemBase[] { textBoxTable, textboxGroup });
            }


            table1.NoDataMessage = @"No Data Available!";
            //table1.DataSource = dataTable;
            //var reportObject = (ReportFull)Report.ReportParameters["reportFull"].Value;
            textBox1.Value = @"Header from Code";
            textBox2.Value = @"First Heading of Image";
            textBox3.Value = @"Second Heading of Image";
            textBox4.Value = @"Signature Value from Code";
            //pictureBox1.Value = @"C:\Users\Techverx\Downloads\1st Image.jpeg";
            //pictureBox2.Value = @"C:\Users\Techverx\Downloads\1st Image.jpeg";
        }
    }
}