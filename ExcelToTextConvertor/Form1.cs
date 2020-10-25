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
        private DataTableCollection dataTableCollection;

        [DllImport("user32.dll")]
        static extern bool HideCaret(System.IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(readonlyUploadExcel.Handle);
        }

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

        }

        private void readonlyUploadExcel_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }



    }
}
