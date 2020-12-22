namespace ExcelToTextConvertor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.lblUploadExcel = new System.Windows.Forms.Label();
            this.readonlyUploadExcel = new System.Windows.Forms.TextBox();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.comboBoxExcelSheet = new System.Windows.Forms.ComboBox();
            this.lblExcelSheet = new System.Windows.Forms.Label();
            this.backgroundWorkerTextFileExport = new System.ComponentModel.BackgroundWorker();
            this.lblTextFileExport = new System.Windows.Forms.Label();
            this.readonlyTextFileExport = new System.Windows.Forms.TextBox();
            this.btnTextFileExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.AllowUserToAddRows = false;
            this.dataGridViewExcel.AllowUserToDeleteRows = false;
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.ReadOnly = true;
            this.dataGridViewExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridViewExcel.Size = new System.Drawing.Size(738, 245);
            this.dataGridViewExcel.TabIndex = 0;
            this.dataGridViewExcel.DataSourceChanged += new System.EventHandler(this.dataGridViewExcel_DataSourceChanged);
            // 
            // lblUploadExcel
            // 
            this.lblUploadExcel.AutoSize = true;
            this.lblUploadExcel.Location = new System.Drawing.Point(13, 308);
            this.lblUploadExcel.Name = "lblUploadExcel";
            this.lblUploadExcel.Size = new System.Drawing.Size(55, 13);
            this.lblUploadExcel.TabIndex = 1;
            this.lblUploadExcel.Text = "Excel File:";
            // 
            // readonlyUploadExcel
            // 
            this.readonlyUploadExcel.Cursor = System.Windows.Forms.Cursors.Default;
            this.readonlyUploadExcel.Location = new System.Drawing.Point(89, 305);
            this.readonlyUploadExcel.Name = "readonlyUploadExcel";
            this.readonlyUploadExcel.ReadOnly = true;
            this.readonlyUploadExcel.Size = new System.Drawing.Size(592, 20);
            this.readonlyUploadExcel.TabIndex = 3;
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(696, 303);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(58, 23);
            this.btnUploadExcel.TabIndex = 4;
            this.btnUploadExcel.Text = "...";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // comboBoxExcelSheet
            // 
            this.comboBoxExcelSheet.FormattingEnabled = true;
            this.comboBoxExcelSheet.Location = new System.Drawing.Point(89, 332);
            this.comboBoxExcelSheet.Name = "comboBoxExcelSheet";
            this.comboBoxExcelSheet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExcelSheet.TabIndex = 5;
            this.comboBoxExcelSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcelSheet_SelectedIndexChanged);
            // 
            // lblExcelSheet
            // 
            this.lblExcelSheet.AutoSize = true;
            this.lblExcelSheet.Location = new System.Drawing.Point(13, 335);
            this.lblExcelSheet.Name = "lblExcelSheet";
            this.lblExcelSheet.Size = new System.Drawing.Size(38, 13);
            this.lblExcelSheet.TabIndex = 6;
            this.lblExcelSheet.Text = "Sheet:";
            // 
            // backgroundWorkerTextFileExport
            // 
            this.backgroundWorkerTextFileExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTextFileExport_DoWork);
            this.backgroundWorkerTextFileExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTextFileExport_RunWorkerCompleted);
            // 
            // lblTextFileExport
            // 
            this.lblTextFileExport.AutoSize = true;
            this.lblTextFileExport.Location = new System.Drawing.Point(13, 362);
            this.lblTextFileExport.Name = "lblTextFileExport";
            this.lblTextFileExport.Size = new System.Drawing.Size(50, 13);
            this.lblTextFileExport.TabIndex = 1;
            this.lblTextFileExport.Text = "Text File:";
            // 
            // readonlyTextFileExport
            // 
            this.readonlyTextFileExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.readonlyTextFileExport.Location = new System.Drawing.Point(89, 359);
            this.readonlyTextFileExport.Name = "readonlyTextFileExport";
            this.readonlyTextFileExport.ReadOnly = true;
            this.readonlyTextFileExport.Size = new System.Drawing.Size(592, 20);
            this.readonlyTextFileExport.TabIndex = 3;
            // 
            // btnTextFileExport
            // 
            this.btnTextFileExport.Location = new System.Drawing.Point(696, 357);
            this.btnTextFileExport.Name = "btnTextFileExport";
            this.btnTextFileExport.Size = new System.Drawing.Size(58, 23);
            this.btnTextFileExport.TabIndex = 4;
            this.btnTextFileExport.Text = "...";
            this.btnTextFileExport.UseVisualStyleBackColor = true;
            this.btnTextFileExport.Click += new System.EventHandler(this.btnTextFileExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExcelSheet);
            this.Controls.Add(this.comboBoxExcelSheet);
            this.Controls.Add(this.btnTextFileExport);
            this.Controls.Add(this.btnUploadExcel);
            this.Controls.Add(this.readonlyTextFileExport);
            this.Controls.Add(this.lblTextFileExport);
            this.Controls.Add(this.readonlyUploadExcel);
            this.Controls.Add(this.lblUploadExcel);
            this.Controls.Add(this.dataGridViewExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.Label lblUploadExcel;
        private System.Windows.Forms.TextBox readonlyUploadExcel;
        private System.Windows.Forms.Button btnUploadExcel;
        private System.Windows.Forms.ComboBox comboBoxExcelSheet;
        private System.Windows.Forms.Label lblExcelSheet;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTextFileExport;
        private System.Windows.Forms.Label lblTextFileExport;
        private System.Windows.Forms.TextBox readonlyTextFileExport;
        private System.Windows.Forms.Button btnTextFileExport;
    }
}

