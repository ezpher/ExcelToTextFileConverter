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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.Size = new System.Drawing.Size(741, 298);
            this.dataGridViewExcel.TabIndex = 0;
            // 
            // lblUploadExcel
            // 
            this.lblUploadExcel.AutoSize = true;
            this.lblUploadExcel.Location = new System.Drawing.Point(12, 335);
            this.lblUploadExcel.Name = "lblUploadExcel";
            this.lblUploadExcel.Size = new System.Drawing.Size(55, 13);
            this.lblUploadExcel.TabIndex = 1;
            this.lblUploadExcel.Text = "Excel File:";
            // 
            // readonlyUploadExcel
            // 
            this.readonlyUploadExcel.Location = new System.Drawing.Point(88, 332);
            this.readonlyUploadExcel.Name = "readonlyUploadExcel";
            this.readonlyUploadExcel.ReadOnly = true;
            this.readonlyUploadExcel.Size = new System.Drawing.Size(592, 20);
            this.readonlyUploadExcel.TabIndex = 3;
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(695, 330);
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
            this.comboBoxExcelSheet.Location = new System.Drawing.Point(88, 359);
            this.comboBoxExcelSheet.Name = "comboBoxExcelSheet";
            this.comboBoxExcelSheet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExcelSheet.TabIndex = 5;
            this.comboBoxExcelSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcelSheet_SelectedIndexChanged);
            // 
            // lblExcelSheet
            // 
            this.lblExcelSheet.AutoSize = true;
            this.lblExcelSheet.Location = new System.Drawing.Point(12, 362);
            this.lblExcelSheet.Name = "lblExcelSheet";
            this.lblExcelSheet.Size = new System.Drawing.Size(38, 13);
            this.lblExcelSheet.TabIndex = 6;
            this.lblExcelSheet.Text = "Sheet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExcelSheet);
            this.Controls.Add(this.comboBoxExcelSheet);
            this.Controls.Add(this.btnUploadExcel);
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
    }
}

