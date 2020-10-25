using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToTextConvertor
{
    public partial class Form1 : Form
    {
        private DataTableCollection dataTableCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxExcelSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataTableCollection != null && dataTableCollection.Count > 0)
            {
                dataGridViewExcel.DataSource = dataTableCollection[comboBoxExcelSheet.SelectedValue.ToString()];
            }
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            // create a open file dialog box on clicking on upload excel button, and set filter to use *.xls and *.xlsx file extensions and their respective descriptions
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97 - 2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                // if open file dialog's ok button was clicked
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // assign file path including file name to the readonly textbox's text
                    readonlyUploadExcel.Text = openFileDialog.FileName;

                    // create a file stream from the opened excel file and read using excel data reader
                    using (FileStream stream = File.Open(openFileDialog.FileName, mode: FileMode.Open, access: FileAccess.Read))
                    {
                        using (IExcelDataReader excelDataReader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // use AsDataSet to return as Dataset the results of reading and also allows us to set optional excel data set configuration
                            DataSet result = excelDataReader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_excelDataReader) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true,
                                }
                            });

                            // retrieve the dataset's tables using dataset.Tables
                            dataTableCollection = result.Tables;

                            // populate combo box for excel sheets with the excel tables retrieved
                            comboBoxExcelSheet.Items.Clear();
                            comboBoxExcelSheet.Items.Add(dataTableCollection);
                        }
                    }
                }
            }
        }
    }
}
