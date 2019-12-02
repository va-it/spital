namespace spital
{
    partial class CentralDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralDisplay));
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_ManagementReport = new System.Windows.Forms.Button();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControl_bed1 = new spital.UserControl_bed();
            this.userControl_bed8 = new spital.UserControl_bed();
            this.userControl_bed7 = new spital.UserControl_bed();
            this.userControl_bed6 = new spital.UserControl_bed();
            this.userControl_bed5 = new spital.UserControl_bed();
            this.userControl_bed4 = new spital.UserControl_bed();
            this.userControl_bed3 = new spital.UserControl_bed();
            this.userControl_bed2 = new spital.UserControl_bed();
            this.button_startshift = new System.Windows.Forms.Button();
            this.button_endshift = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Bay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.bt_ManagementReport);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(807, 81);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bt_ManagementReport
            // 
            this.bt_ManagementReport.BackColor = System.Drawing.Color.Gold;
            this.bt_ManagementReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManagementReport.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.bt_ManagementReport.ForeColor = System.Drawing.Color.Black;
            this.bt_ManagementReport.Location = new System.Drawing.Point(621, 23);
            this.bt_ManagementReport.Name = "bt_ManagementReport";
            this.bt_ManagementReport.Size = new System.Drawing.Size(174, 36);
            this.bt_ManagementReport.TabIndex = 1;
            this.bt_ManagementReport.Text = "Management Reports";
            this.bt_ManagementReport.UseVisualStyleBackColor = false;
            this.bt_ManagementReport.Click += new System.EventHandler(this.bt_ManagementReport_Click);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.labelcopyright);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 456);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(807, 40);
            this.panel_footer.TabIndex = 1;
            // 
            // labelcopyright
            // 
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcopyright.Location = new System.Drawing.Point(327, 10);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(192, 15);
            this.labelcopyright.TabIndex = 0;
            this.labelcopyright.Text = "© 2019 East Anglia Hospital trust";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.userControl_bed1);
            this.groupBox1.Controls.Add(this.userControl_bed8);
            this.groupBox1.Controls.Add(this.userControl_bed7);
            this.groupBox1.Controls.Add(this.userControl_bed6);
            this.groupBox1.Controls.Add(this.userControl_bed5);
            this.groupBox1.Controls.Add(this.userControl_bed4);
            this.groupBox1.Controls.Add(this.userControl_bed3);
            this.groupBox1.Controls.Add(this.userControl_bed2);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bay";
            // 
            // userControl_bed1
            // 
            this.userControl_bed1.Alert = "";
            this.userControl_bed1.AlertPictureBox = null;
            this.userControl_bed1.BackColor = System.Drawing.Color.White;
            this.userControl_bed1.BedNumber = "Bed 1";
            this.userControl_bed1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed1.Location = new System.Drawing.Point(23, 25);
            this.userControl_bed1.MonitorID = "1";
            this.userControl_bed1.Name = "userControl_bed1";
            this.userControl_bed1.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed1.TabIndex = 7;
            this.userControl_bed1.Click += new System.EventHandler(this.userControl_bed1_Click);
            // 
            // userControl_bed8
            // 
            this.userControl_bed8.Alert = "";
            this.userControl_bed8.AlertPictureBox = null;
            this.userControl_bed8.BackColor = System.Drawing.Color.White;
            this.userControl_bed8.BedNumber = "Bed 8";
            this.userControl_bed8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed8.Location = new System.Drawing.Point(630, 170);
            this.userControl_bed8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed8.MonitorID = "8";
            this.userControl_bed8.Name = "userControl_bed8";
            this.userControl_bed8.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed8.TabIndex = 7;
            this.userControl_bed8.Click += new System.EventHandler(this.userControl_bed8_Click);
            // 
            // userControl_bed7
            // 
            this.userControl_bed7.Alert = "";
            this.userControl_bed7.AlertPictureBox = null;
            this.userControl_bed7.BackColor = System.Drawing.Color.White;
            this.userControl_bed7.BedNumber = "Bed 7";
            this.userControl_bed7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed7.Location = new System.Drawing.Point(432, 170);
            this.userControl_bed7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed7.MonitorID = "7";
            this.userControl_bed7.Name = "userControl_bed7";
            this.userControl_bed7.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed7.TabIndex = 6;
            this.userControl_bed7.Click += new System.EventHandler(this.userControl_bed7_Click);
            // 
            // userControl_bed6
            // 
            this.userControl_bed6.Alert = "";
            this.userControl_bed6.AlertPictureBox = null;
            this.userControl_bed6.BackColor = System.Drawing.Color.White;
            this.userControl_bed6.BedNumber = "Bed 6";
            this.userControl_bed6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed6.Location = new System.Drawing.Point(227, 170);
            this.userControl_bed6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed6.MonitorID = "6";
            this.userControl_bed6.Name = "userControl_bed6";
            this.userControl_bed6.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed6.TabIndex = 5;
            this.userControl_bed6.Click += new System.EventHandler(this.userControl_bed6_Click);
            // 
            // userControl_bed5
            // 
            this.userControl_bed5.Alert = "";
            this.userControl_bed5.AlertPictureBox = null;
            this.userControl_bed5.BackColor = System.Drawing.Color.White;
            this.userControl_bed5.BedNumber = "Bed 5";
            this.userControl_bed5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed5.Location = new System.Drawing.Point(23, 170);
            this.userControl_bed5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed5.MonitorID = "5";
            this.userControl_bed5.Name = "userControl_bed5";
            this.userControl_bed5.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed5.TabIndex = 4;
            this.userControl_bed5.Click += new System.EventHandler(this.userControl_bed5_Click);
            // 
            // userControl_bed4
            // 
            this.userControl_bed4.Alert = "";
            this.userControl_bed4.AlertPictureBox = null;
            this.userControl_bed4.BackColor = System.Drawing.Color.White;
            this.userControl_bed4.BedNumber = "Bed 4";
            this.userControl_bed4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed4.Location = new System.Drawing.Point(629, 25);
            this.userControl_bed4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed4.MonitorID = "4";
            this.userControl_bed4.Name = "userControl_bed4";
            this.userControl_bed4.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed4.TabIndex = 3;
            this.userControl_bed4.Click += new System.EventHandler(this.userControl_bed4_Click);
            // 
            // userControl_bed3
            // 
            this.userControl_bed3.Alert = "";
            this.userControl_bed3.AlertPictureBox = null;
            this.userControl_bed3.BackColor = System.Drawing.Color.White;
            this.userControl_bed3.BedNumber = "Bed 3";
            this.userControl_bed3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed3.Location = new System.Drawing.Point(432, 25);
            this.userControl_bed3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed3.MonitorID = "3";
            this.userControl_bed3.Name = "userControl_bed3";
            this.userControl_bed3.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed3.TabIndex = 2;
            this.userControl_bed3.Click += new System.EventHandler(this.userControl_bed3_Click);
            // 
            // userControl_bed2
            // 
            this.userControl_bed2.Alert = "";
            this.userControl_bed2.AlertPictureBox = null;
            this.userControl_bed2.BackColor = System.Drawing.Color.White;
            this.userControl_bed2.BedNumber = "Bed 2";
            this.userControl_bed2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControl_bed2.Location = new System.Drawing.Point(227, 25);
            this.userControl_bed2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_bed2.MonitorID = "2";
            this.userControl_bed2.Name = "userControl_bed2";
            this.userControl_bed2.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed2.TabIndex = 1;
            this.userControl_bed2.Click += new System.EventHandler(this.userControl_bed2_Click);
            // 
            // button_startshift
            // 
            this.button_startshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button_startshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startshift.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.button_startshift.ForeColor = System.Drawing.Color.White;
            this.button_startshift.Location = new System.Drawing.Point(359, 408);
            this.button_startshift.Name = "button_startshift";
            this.button_startshift.Size = new System.Drawing.Size(114, 37);
            this.button_startshift.TabIndex = 3;
            this.button_startshift.Text = "Start Session";
            this.button_startshift.UseVisualStyleBackColor = false;
            this.button_startshift.Click += new System.EventHandler(this.button_startshift_Click);
            // 
            // button_endshift
            // 
            this.button_endshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button_endshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_endshift.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.button_endshift.ForeColor = System.Drawing.Color.White;
            this.button_endshift.Location = new System.Drawing.Point(630, 408);
            this.button_endshift.Name = "button_endshift";
            this.button_endshift.Size = new System.Drawing.Size(114, 37);
            this.button_endshift.TabIndex = 4;
            this.button_endshift.Text = "End Session";
            this.button_endshift.UseVisualStyleBackColor = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Calibri", 10.125F);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(70, 408);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(114, 37);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register Staff";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // flowLayoutPanel_Bay
            // 
            this.flowLayoutPanel_Bay.Location = new System.Drawing.Point(77, 102);
            this.flowLayoutPanel_Bay.Name = "flowLayoutPanel_Bay";
            this.flowLayoutPanel_Bay.Size = new System.Drawing.Size(662, 280);
            this.flowLayoutPanel_Bay.TabIndex = 6;
            // 
            // CentralDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 496);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.button_endshift);
            this.Controls.Add(this.button_startshift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.flowLayoutPanel_Bay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CentralDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Display";
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_startshift;
        private System.Windows.Forms.Button button_endshift;
        private System.Windows.Forms.Label labelcopyright;
        private System.Windows.Forms.Button buttonRegister;
        private UserControl_bed userControl_bed8;
        private UserControl_bed userControl_bed7;
        private UserControl_bed userControl_bed6;
        private UserControl_bed userControl_bed5;
        private UserControl_bed userControl_bed4;
        private UserControl_bed userControl_bed3;
        private UserControl_bed userControl_bed2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Bay;
        private System.Windows.Forms.Button bt_ManagementReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl_bed userControl_bed1;
    }
}