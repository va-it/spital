namespace spital
{
    partial class ManagementForm
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.label_copyRight = new System.Windows.Forms.Label();
            this.AlarmReport_DataGrid = new System.Windows.Forms.DataGridView();
            this.SessionReport_DataGrid = new System.Windows.Forms.DataGridView();
            this.label_AlarmReport = new System.Windows.Forms.Label();
            this.label_SessionReport = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionReport_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox_logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(798, 104);
            this.panel_header.TabIndex = 35;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::spital.Properties.Resources.Logo_EAHT;
            this.pictureBox_logo.Location = new System.Drawing.Point(15, 13);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(272, 73);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.label_copyRight);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 480);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(798, 52);
            this.panel_footer.TabIndex = 36;
            // 
            // label_copyRight
            // 
            this.label_copyRight.AutoSize = true;
            this.label_copyRight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_copyRight.Location = new System.Drawing.Point(272, 14);
            this.label_copyRight.Name = "label_copyRight";
            this.label_copyRight.Size = new System.Drawing.Size(193, 15);
            this.label_copyRight.TabIndex = 18;
            this.label_copyRight.Text = "© 2019 East Anglia Hospital Trust";
            // 
            // AlarmReport_DataGrid
            // 
            this.AlarmReport_DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AlarmReport_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlarmReport_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmReport_DataGrid.Location = new System.Drawing.Point(0, 147);
            this.AlarmReport_DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlarmReport_DataGrid.Name = "AlarmReport_DataGrid";
            this.AlarmReport_DataGrid.RowTemplate.Height = 33;
            this.AlarmReport_DataGrid.Size = new System.Drawing.Size(390, 332);
            this.AlarmReport_DataGrid.TabIndex = 1;
            // 
            // SessionReport_DataGrid
            // 
            this.SessionReport_DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.SessionReport_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SessionReport_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionReport_DataGrid.Location = new System.Drawing.Point(399, 147);
            this.SessionReport_DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SessionReport_DataGrid.Name = "SessionReport_DataGrid";
            this.SessionReport_DataGrid.RowTemplate.Height = 33;
            this.SessionReport_DataGrid.Size = new System.Drawing.Size(399, 332);
            this.SessionReport_DataGrid.TabIndex = 38;
            // 
            // label_AlarmReport
            // 
            this.label_AlarmReport.AutoSize = true;
            this.label_AlarmReport.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label_AlarmReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_AlarmReport.Location = new System.Drawing.Point(138, 117);
            this.label_AlarmReport.Name = "label_AlarmReport";
            this.label_AlarmReport.Size = new System.Drawing.Size(79, 15);
            this.label_AlarmReport.TabIndex = 39;
            this.label_AlarmReport.Text = "Alarm Report";
            // 
            // label_SessionReport
            // 
            this.label_SessionReport.AutoSize = true;
            this.label_SessionReport.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label_SessionReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_SessionReport.Location = new System.Drawing.Point(541, 117);
            this.label_SessionReport.Name = "label_SessionReport";
            this.label_SessionReport.Size = new System.Drawing.Size(88, 15);
            this.label_SessionReport.TabIndex = 40;
            this.label_SessionReport.Text = "Session Report";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 532);
            this.Controls.Add(this.label_SessionReport);
            this.Controls.Add(this.label_AlarmReport);
            this.Controls.Add(this.SessionReport_DataGrid);
            this.Controls.Add(this.AlarmReport_DataGrid);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionReport_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label label_copyRight;
        private System.Windows.Forms.DataGridView AlarmReport_DataGrid;
        private System.Windows.Forms.DataGridView SessionReport_DataGrid;
        private System.Windows.Forms.Label label_AlarmReport;
        private System.Windows.Forms.Label label_SessionReport;
    }
}