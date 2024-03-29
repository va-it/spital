﻿namespace spital
{
    partial class UserControl_bed
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_bednumber = new System.Windows.Forms.Label();
            this.button_mute = new System.Windows.Forms.Button();
            this.pictureBox_alert = new System.Windows.Forms.PictureBox();
            this.pictureBox_bed = new System.Windows.Forms.PictureBox();
            this.label_alertmsg = new System.Windows.Forms.Label();
            this.hiddenLabel_MonitorID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bed)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bednumber
            // 
            this.label_bednumber.AutoSize = true;
            this.label_bednumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label_bednumber.Location = new System.Drawing.Point(3, 0);
            this.label_bednumber.Name = "label_bednumber";
            this.label_bednumber.Size = new System.Drawing.Size(0, 19);
            this.label_bednumber.TabIndex = 0;
            // 
            // button_mute
            // 
            this.button_mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mute.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mute.ForeColor = System.Drawing.Color.White;
            this.button_mute.Location = new System.Drawing.Point(3, 56);
            this.button_mute.Name = "button_mute";
            this.button_mute.Size = new System.Drawing.Size(57, 26);
            this.button_mute.TabIndex = 1;
            this.button_mute.Text = "Mute";
            this.button_mute.UseVisualStyleBackColor = false;
            this.button_mute.Click += new System.EventHandler(this.button_mute_Click);
            // 
            // pictureBox_alert
            // 
            this.pictureBox_alert.Location = new System.Drawing.Point(13, 20);
            this.pictureBox_alert.Name = "pictureBox_alert";
            this.pictureBox_alert.Size = new System.Drawing.Size(37, 33);
            this.pictureBox_alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_alert.TabIndex = 2;
            this.pictureBox_alert.TabStop = false;
            // 
            // pictureBox_bed
            // 
            this.pictureBox_bed.Image = global::spital.Properties.Resources.icon_Patient;
            this.pictureBox_bed.Location = new System.Drawing.Point(63, 10);
            this.pictureBox_bed.Name = "pictureBox_bed";
            this.pictureBox_bed.Size = new System.Drawing.Size(61, 72);
            this.pictureBox_bed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bed.TabIndex = 3;
            this.pictureBox_bed.TabStop = false;
            // 
            // label_alertmsg
            // 
            this.label_alertmsg.AutoSize = true;
            this.label_alertmsg.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alertmsg.ForeColor = System.Drawing.Color.Red;
            this.label_alertmsg.Location = new System.Drawing.Point(3, 85);
            this.label_alertmsg.Name = "label_alertmsg";
            this.label_alertmsg.Size = new System.Drawing.Size(0, 13);
            this.label_alertmsg.TabIndex = 4;
            // 
            // hiddenLabel_MonitorID
            // 
            this.hiddenLabel_MonitorID.AutoSize = true;
            this.hiddenLabel_MonitorID.Location = new System.Drawing.Point(116, 85);
            this.hiddenLabel_MonitorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenLabel_MonitorID.Name = "hiddenLabel_MonitorID";
            this.hiddenLabel_MonitorID.Size = new System.Drawing.Size(0, 13);
            this.hiddenLabel_MonitorID.TabIndex = 5;
            this.hiddenLabel_MonitorID.Visible = false;
            // 
            // UserControl_bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.hiddenLabel_MonitorID);
            this.Controls.Add(this.label_alertmsg);
            this.Controls.Add(this.pictureBox_bed);
            this.Controls.Add(this.pictureBox_alert);
            this.Controls.Add(this.button_mute);
            this.Controls.Add(this.label_bednumber);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControl_bed";
            this.Size = new System.Drawing.Size(129, 118);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_bednumber;
        public System.Windows.Forms.Button button_mute;
        public System.Windows.Forms.PictureBox pictureBox_alert;
        public System.Windows.Forms.PictureBox pictureBox_bed;
        public System.Windows.Forms.Label label_alertmsg;
        public System.Windows.Forms.Label hiddenLabel_MonitorID;
    }
}
