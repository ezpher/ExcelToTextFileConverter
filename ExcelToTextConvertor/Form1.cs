using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToTextConvertor
{
    public partial class Form1 : Form
    {

        #region Non-Event Handlers e.g. private variables

        private DataTableCollection DataTableCollection { get; set; }

        private struct TxtFileWorkerThreadParams
        {
            public string FileName { get; set; }
            public DataGridViewRowCollection DataGridViewRowCollection { get; set; }
            public DataGridViewSelectedColumnCollection DataGridViewSelectedColumnCollection { get; set; }

        }

        TxtFileWorkerThreadParams _inputParams;

        [DllImport("user32.dll")]
        static extern bool HideCaret(System.IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(readonlyUploadExcel.Handle);
        }

        #endregion

        #region Form Event Handlers

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxExcelSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataTableCollection != null && DataTableCollection.Count > 0)
            {
                // by default the dgv selection mode is column header select, need to change to row header select or will trigger
                // invalid operation exception when selecting a worksheet to bind from the uploaded excel file i.e.: 
                // column's sortmode cannot be set to automatic while the datagridview control's selectionmode is set to columnheaderselect.

                // only upon binding to datasource, then change back selection mode back to column header select in the data source changed event handler
                dataGridViewExcel.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                dataGridViewExcel.DataSource = DataTableCollection[comboBoxExcelSheet.SelectedItem.ToString()];
            }

        }

        private void dataGridViewExcel_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewExcel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridViewExcel.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
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
                            DataTableCollection = result.Tables;

                            // populate combo box for excel sheets with the excel tables retrieved
                            comboBoxExcelSheet.Items.Clear();

                            foreach (DataTable dt in DataTableCollection)
                            {
                                comboBoxExcelSheet.Items.Add(dt.TableName);
                            }
                        }
                    }
                }
            }
        }

        // hide blinking ibeam cursor on focus of the readonly textbox
        private void readonlyUploadExcel_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }

        private void btnTextFileExport_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerTextFileExport.IsBusy) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Documents|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK
                    && dataGridViewExcel.SelectedColumns != null
                    && dataGridViewExcel.SelectedColumns.Count > 0)
                {

                    readonlyTextFileExport.Text = saveFileDialog.FileName;

                    _inputParams.FileName = saveFileDialog.FileName;
                    _inputParams.DataGridViewRowCollection = dataGridViewExcel.Rows;
                    _inputParams.DataGridViewSelectedColumnCollection = dataGridViewExcel.SelectedColumns;

                    backgroundWorkerTextFileExport.RunWorkerAsync(_inputParams);
                }
            }
        }

        private void backgroundWorkerTextFileExport_DoWork(object sender, DoWorkEventArgs e)
        {
            DataGridViewRowCollection dataGridViewRowCollection = ((TxtFileWorkerThreadParams)e.Argument).DataGridViewRowCollection;
            DataGridViewSelectedColumnCollection dataGridViewSelectedColumnCollection = ((TxtFileWorkerThreadParams)e.Argument).DataGridViewSelectedColumnCollection;

            string fileName = ((TxtFileWorkerThreadParams)e.Argument).FileName;

            if (!File.Exists(fileName))
            {
                using (File.Create(fileName)) { };
            }

            using (TextWriter txtWriter = new StreamWriter(new FileStream(fileName, mode: FileMode.Append, access: FileAccess.Write), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewRow row in dataGridViewRowCollection)
                {
                    for (int colIndex = 0; colIndex < dataGridViewSelectedColumnCollection.Count; colIndex++)
                    {
                        sb.Append(row.Cells[dataGridViewSelectedColumnCollection[colIndex].DisplayIndex].Value);
                        sb.Append("\t");
                    }

                    sb.AppendLine();

                }

                sb.AppendLine();

                txtWriter.Write(sb.ToString());
            }
        }

        private void backgroundWorkerTextFileExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Your data has been successfully exported");
            }
        }

        #endregion

    }
}
