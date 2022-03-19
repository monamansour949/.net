namespace Garage
{
    partial class SalesReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateFrmLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TODatelLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FromDateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToDateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Print = new Guna.UI2.WinForms.Guna2Button();
            this.ReportdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateFrmLabel1
            // 
            this.DateFrmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.DateFrmLabel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DateFrmLabel1.ForeColor = System.Drawing.Color.White;
            this.DateFrmLabel1.Location = new System.Drawing.Point(111, 39);
            this.DateFrmLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateFrmLabel1.Name = "DateFrmLabel1";
            this.DateFrmLabel1.Size = new System.Drawing.Size(77, 21);
            this.DateFrmLabel1.TabIndex = 2;
            this.DateFrmLabel1.Text = "From Date";
            // 
            // TODatelLabel1
            // 
            this.TODatelLabel1.BackColor = System.Drawing.Color.Transparent;
            this.TODatelLabel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TODatelLabel1.ForeColor = System.Drawing.Color.White;
            this.TODatelLabel1.Location = new System.Drawing.Point(498, 39);
            this.TODatelLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TODatelLabel1.Name = "TODatelLabel1";
            this.TODatelLabel1.Size = new System.Drawing.Size(59, 21);
            this.TODatelLabel1.TabIndex = 3;
            this.TODatelLabel1.Text = "To Date";
            // 
            // FromDateTimePicker1
            // 
            this.FromDateTimePicker1.Checked = true;
            this.FromDateTimePicker1.CheckedState.Parent = this.FromDateTimePicker1;
            this.FromDateTimePicker1.FillColor = System.Drawing.Color.Crimson;
            this.FromDateTimePicker1.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.FromDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDateTimePicker1.HoverState.Parent = this.FromDateTimePicker1;
            this.FromDateTimePicker1.Location = new System.Drawing.Point(208, 39);
            this.FromDateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FromDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDateTimePicker1.Name = "FromDateTimePicker1";
            this.FromDateTimePicker1.ShadowDecoration.Parent = this.FromDateTimePicker1;
            this.FromDateTimePicker1.Size = new System.Drawing.Size(256, 29);
            this.FromDateTimePicker1.TabIndex = 4;
            this.FromDateTimePicker1.Value = new System.DateTime(2022, 2, 8, 2, 49, 59, 608);
            // 
            // ToDateTimePicker1
            // 
            this.ToDateTimePicker1.Checked = true;
            this.ToDateTimePicker1.CheckedState.Parent = this.ToDateTimePicker1;
            this.ToDateTimePicker1.FillColor = System.Drawing.Color.Crimson;
            this.ToDateTimePicker1.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.ToDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDateTimePicker1.HoverState.Parent = this.ToDateTimePicker1;
            this.ToDateTimePicker1.Location = new System.Drawing.Point(594, 39);
            this.ToDateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDateTimePicker1.Name = "ToDateTimePicker1";
            this.ToDateTimePicker1.ShadowDecoration.Parent = this.ToDateTimePicker1;
            this.ToDateTimePicker1.Size = new System.Drawing.Size(278, 29);
            this.ToDateTimePicker1.TabIndex = 5;
            this.ToDateTimePicker1.Value = new System.DateTime(2022, 2, 8, 2, 49, 59, 608);
            // 
            // Print
            // 
            this.Print.CheckedState.Parent = this.Print;
            this.Print.CustomImages.Parent = this.Print;
            this.Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Print.DisabledState.Parent = this.Print;
            this.Print.FillColor = System.Drawing.Color.Crimson;
            this.Print.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.HoverState.Parent = this.Print;
            this.Print.Location = new System.Drawing.Point(914, 39);
            this.Print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Print.Name = "Print";
            this.Print.ShadowDecoration.Parent = this.Print;
            this.Print.Size = new System.Drawing.Size(154, 37);
            this.Print.TabIndex = 7;
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // ReportdataGridView1
            // 
            this.ReportdataGridView1.AllowUserToAddRows = false;
            this.ReportdataGridView1.AllowUserToDeleteRows = false;
            this.ReportdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportdataGridView1.Location = new System.Drawing.Point(265, 117);
            this.ReportdataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportdataGridView1.Name = "ReportdataGridView1";
            this.ReportdataGridView1.ReadOnly = true;
            this.ReportdataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ReportdataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportdataGridView1.RowTemplate.Height = 26;
            this.ReportdataGridView1.Size = new System.Drawing.Size(490, 284);
            this.ReportdataGridView1.TabIndex = 8;
            this.ReportdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportdataGridView1_CellClick);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1040, 535);
            this.Controls.Add(this.ReportdataGridView1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.ToDateTimePicker1);
            this.Controls.Add(this.FromDateTimePicker1);
            this.Controls.Add(this.TODatelLabel1);
            this.Controls.Add(this.DateFrmLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel DateFrmLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel TODatelLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button Print;
        private System.Windows.Forms.DataGridView ReportdataGridView1;
    }
}