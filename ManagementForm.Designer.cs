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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AlarmReport_Panel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AlarmReport_DataGrid = new System.Windows.Forms.DataGridView();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AlarmReport_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox_logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1284, 173);
            this.panel_header.TabIndex = 35;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::spital.Properties.Resources.Logo_EAHT;
            this.pictureBox_logo.Location = new System.Drawing.Point(26, 21);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(466, 121);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.label_copyRight);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 694);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1284, 87);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.AlarmReport_DataGrid);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(24, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 498);
            this.panel1.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Alarm Report";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlarmReport_Panel
            // 
            this.AlarmReport_Panel.Controls.Add(this.textBox2);
            this.AlarmReport_Panel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmReport_Panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlarmReport_Panel.Location = new System.Drawing.Point(630, 185);
            this.AlarmReport_Panel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AlarmReport_Panel.Name = "AlarmReport_Panel";
            this.AlarmReport_Panel.Size = new System.Drawing.Size(630, 498);
            this.AlarmReport_Panel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 39);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Staff Report";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlarmReport_DataGrid
            // 
            this.AlarmReport_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmReport_DataGrid.Location = new System.Drawing.Point(3, 63);
            this.AlarmReport_DataGrid.Name = "AlarmReport_DataGrid";
            this.AlarmReport_DataGrid.RowTemplate.Height = 33;
            this.AlarmReport_DataGrid.Size = new System.Drawing.Size(588, 423);
            this.AlarmReport_DataGrid.TabIndex = 1;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.AlarmReport_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AlarmReport_Panel.ResumeLayout(false);
            this.AlarmReport_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReport_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label label_copyRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel AlarmReport_Panel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView AlarmReport_DataGrid;
    }
}