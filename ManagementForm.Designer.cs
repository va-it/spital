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
            this.panel_footer = new System.Windows.Forms.Panel();
            this.label_copyRight = new System.Windows.Forms.Label();
            this.AlarmReport_DataGrid = new System.Windows.Forms.DataGridView();
            this.SessionReport_DataGrid = new System.Windows.Forms.DataGridView();
            this.AlarmReportTextbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionReport_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox_logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(6);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1368, 173);
            this.panel_header.TabIndex = 35;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.label_copyRight);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 800);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(6);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1368, 87);
            this.panel_footer.TabIndex = 36;
            // 
            // label_copyRight
            // 
            this.label_copyRight.AutoSize = true;
            this.label_copyRight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_copyRight.Location = new System.Drawing.Point(466, 23);
            this.label_copyRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_copyRight.Name = "label_copyRight";
            this.label_copyRight.Size = new System.Drawing.Size(368, 32);
            this.label_copyRight.TabIndex = 18;
            this.label_copyRight.Text = "© 2019 East Anglia Hospital Trust";
            // 
            // AlarmReport_DataGrid
            // 
            this.AlarmReport_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmReport_DataGrid.Location = new System.Drawing.Point(0, 245);
            this.AlarmReport_DataGrid.Name = "AlarmReport_DataGrid";
            this.AlarmReport_DataGrid.RowTemplate.Height = 33;
            this.AlarmReport_DataGrid.Size = new System.Drawing.Size(668, 554);
            this.AlarmReport_DataGrid.TabIndex = 1;
            // 
            // SessionReport_DataGrid
            // 
            this.SessionReport_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionReport_DataGrid.Location = new System.Drawing.Point(684, 245);
            this.SessionReport_DataGrid.Name = "SessionReport_DataGrid";
            this.SessionReport_DataGrid.RowTemplate.Height = 33;
            this.SessionReport_DataGrid.Size = new System.Drawing.Size(684, 554);
            this.SessionReport_DataGrid.TabIndex = 38;
            // 
            // AlarmReportTextbox
            // 
            this.AlarmReportTextbox.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmReportTextbox.Location = new System.Drawing.Point(128, 194);
            this.AlarmReportTextbox.Name = "AlarmReportTextbox";
            this.AlarmReportTextbox.Size = new System.Drawing.Size(373, 40);
            this.AlarmReportTextbox.TabIndex = 0;
            this.AlarmReportTextbox.Text = "Alarm Report";
            this.AlarmReportTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(818, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 40);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "Sessions Report";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::spital.Properties.Resources.Logo_EAHT;
            this.pictureBox_logo.Location = new System.Drawing.Point(26, 21);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(466, 121);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 887);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AlarmReportTextbox);
            this.Controls.Add(this.SessionReport_DataGrid);
            this.Controls.Add(this.AlarmReport_DataGrid);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.panel_header.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionReport_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
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
        private System.Windows.Forms.TextBox AlarmReportTextbox;
        private System.Windows.Forms.TextBox textBox2;
    }
}