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
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControl_bed8 = new spital.UserControl_bed();
            this.userControl_bed7 = new spital.UserControl_bed();
            this.userControl_bed6 = new spital.UserControl_bed();
            this.userControl_bed5 = new spital.UserControl_bed();
            this.userControl_bed4 = new spital.UserControl_bed();
            this.userControl_bed3 = new spital.UserControl_bed();
            this.userControl_bed2 = new spital.UserControl_bed();
            this.userControl_bed1 = new spital.UserControl_bed();
            this.button_startshift = new System.Windows.Forms.Button();
            this.button_endshift = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox_logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(702, 81);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(215, 60);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.labelcopyright);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 449);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(702, 39);
            this.panel_footer.TabIndex = 1;
            // 
            // labelcopyright
            // 
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcopyright.Location = new System.Drawing.Point(254, 10);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(192, 15);
            this.labelcopyright.TabIndex = 0;
            this.labelcopyright.Text = "© 2019 East Anglia Hospital trust";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.userControl_bed8);
            this.groupBox1.Controls.Add(this.userControl_bed7);
            this.groupBox1.Controls.Add(this.userControl_bed6);
            this.groupBox1.Controls.Add(this.userControl_bed5);
            this.groupBox1.Controls.Add(this.userControl_bed4);
            this.groupBox1.Controls.Add(this.userControl_bed3);
            this.groupBox1.Controls.Add(this.userControl_bed2);
            this.groupBox1.Controls.Add(this.userControl_bed1);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bay";
            // 
            // userControl_bed8
            // 
            this.userControl_bed8.Alert = "";
            this.userControl_bed8.BackColor = System.Drawing.Color.White;
            this.userControl_bed8.BedNumber = "";
            this.userControl_bed8.Location = new System.Drawing.Point(523, 170);
            this.userControl_bed8.MonitorID = "0";
            this.userControl_bed8.Name = "userControl_bed8";
            this.userControl_bed8.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed8.TabIndex = 7;
            this.userControl_bed8.Click += new System.EventHandler(this.userControl_bed8_Click);
            // 
            // userControl_bed7
            // 
            this.userControl_bed7.Alert = "";
            this.userControl_bed7.BackColor = System.Drawing.Color.White;
            this.userControl_bed7.BedNumber = "";
            this.userControl_bed7.Location = new System.Drawing.Point(353, 170);
            this.userControl_bed7.MonitorID = "0";
            this.userControl_bed7.Name = "userControl_bed7";
            this.userControl_bed7.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed7.TabIndex = 6;
            this.userControl_bed7.Click += new System.EventHandler(this.userControl_bed7_Click);
            // 
            // userControl_bed6
            // 
            this.userControl_bed6.Alert = "";
            this.userControl_bed6.BackColor = System.Drawing.Color.White;
            this.userControl_bed6.BedNumber = "";
            this.userControl_bed6.Location = new System.Drawing.Point(183, 170);
            this.userControl_bed6.MonitorID = "0";
            this.userControl_bed6.Name = "userControl_bed6";
            this.userControl_bed6.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed6.TabIndex = 5;
            this.userControl_bed6.Click += new System.EventHandler(this.userControl_bed6_Click);
            // 
            // userControl_bed5
            // 
            this.userControl_bed5.Alert = "";
            this.userControl_bed5.BackColor = System.Drawing.Color.White;
            this.userControl_bed5.BedNumber = "";
            this.userControl_bed5.Location = new System.Drawing.Point(13, 170);
            this.userControl_bed5.MonitorID = "0";
            this.userControl_bed5.Name = "userControl_bed5";
            this.userControl_bed5.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed5.TabIndex = 4;
            this.userControl_bed5.Click += new System.EventHandler(this.userControl_bed5_Click);
            // 
            // userControl_bed4
            // 
            this.userControl_bed4.Alert = "";
            this.userControl_bed4.BackColor = System.Drawing.Color.White;
            this.userControl_bed4.BedNumber = "";
            this.userControl_bed4.Location = new System.Drawing.Point(523, 25);
            this.userControl_bed4.MonitorID = "0";
            this.userControl_bed4.Name = "userControl_bed4";
            this.userControl_bed4.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed4.TabIndex = 3;
            this.userControl_bed4.Click += new System.EventHandler(this.userControl_bed4_Click);
            // 
            // userControl_bed3
            // 
            this.userControl_bed3.Alert = "";
            this.userControl_bed3.BackColor = System.Drawing.Color.White;
            this.userControl_bed3.BedNumber = "";
            this.userControl_bed3.Location = new System.Drawing.Point(353, 25);
            this.userControl_bed3.MonitorID = "0";
            this.userControl_bed3.Name = "userControl_bed3";
            this.userControl_bed3.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed3.TabIndex = 2;
            this.userControl_bed3.Click += new System.EventHandler(this.userControl_bed3_Click);
            // 
            // userControl_bed2
            // 
            this.userControl_bed2.Alert = "";
            this.userControl_bed2.BackColor = System.Drawing.Color.White;
            this.userControl_bed2.BedNumber = "";
            this.userControl_bed2.Location = new System.Drawing.Point(183, 25);
            this.userControl_bed2.MonitorID = "0";
            this.userControl_bed2.Name = "userControl_bed2";
            this.userControl_bed2.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed2.TabIndex = 1;
            this.userControl_bed2.Click += new System.EventHandler(this.userControl_bed2_Click);
            // 
            // userControl_bed1
            // 
            this.userControl_bed1.Alert = "";
            this.userControl_bed1.BackColor = System.Drawing.Color.White;
            this.userControl_bed1.BedNumber = "";
            this.userControl_bed1.Location = new System.Drawing.Point(13, 25);
            this.userControl_bed1.MonitorID = "0";
            this.userControl_bed1.Name = "userControl_bed1";
            this.userControl_bed1.Size = new System.Drawing.Size(129, 118);
            this.userControl_bed1.TabIndex = 0;
            this.userControl_bed1.Click += new System.EventHandler(this.userControl_bed1_Click);
            // 
            // button_startshift
            // 
            this.button_startshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button_startshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startshift.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startshift.ForeColor = System.Drawing.Color.White;
            this.button_startshift.Location = new System.Drawing.Point(287, 395);
            this.button_startshift.Name = "button_startshift";
            this.button_startshift.Size = new System.Drawing.Size(114, 37);
            this.button_startshift.TabIndex = 3;
            this.button_startshift.Text = "Start Session";
            this.button_startshift.UseVisualStyleBackColor = false;
            // 
            // button_endshift
            // 
            this.button_endshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button_endshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_endshift.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_endshift.ForeColor = System.Drawing.Color.White;
            this.button_endshift.Location = new System.Drawing.Point(493, 395);
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
            this.buttonRegister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(61, 395);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(114, 37);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register Staff";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // CentralDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 488);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.button_endshift);
            this.Controls.Add(this.button_startshift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CentralDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Display";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.PictureBox pictureBox_logo;
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
        private UserControl_bed userControl_bed1;
    }
}