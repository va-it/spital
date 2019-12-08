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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.label_copyRight = new System.Windows.Forms.Label();
            this.Alarms_DataGrid = new System.Windows.Forms.DataGridView();
            this.Sessions_DataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_header.SuspendLayout();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alarms_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sessions_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(637, 83);
            this.panel_header.TabIndex = 35;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel_footer.Controls.Add(this.label_copyRight);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 459);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(637, 40);
            this.panel_footer.TabIndex = 36;
            // 
            // label_copyRight
            // 
            this.label_copyRight.AutoSize = true;
            this.label_copyRight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_copyRight.Location = new System.Drawing.Point(230, 14);
            this.label_copyRight.Name = "label_copyRight";
            this.label_copyRight.Size = new System.Drawing.Size(193, 15);
            this.label_copyRight.TabIndex = 18;
            this.label_copyRight.Text = "© 2019 East Anglia Hospital Trust";
            // 
            // Alarms_DataGrid
            // 
            this.Alarms_DataGrid.AllowUserToAddRows = false;
            this.Alarms_DataGrid.AllowUserToDeleteRows = false;
            this.Alarms_DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.Alarms_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alarms_DataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Alarms_DataGrid.Location = new System.Drawing.Point(5, 5);
            this.Alarms_DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.Alarms_DataGrid.Name = "Alarms_DataGrid";
            this.Alarms_DataGrid.ReadOnly = true;
            this.Alarms_DataGrid.RowTemplate.Height = 33;
            this.Alarms_DataGrid.Size = new System.Drawing.Size(584, 310);
            this.Alarms_DataGrid.TabIndex = 1;
            // 
            // Sessions_DataGrid
            // 
            this.Sessions_DataGrid.AllowUserToAddRows = false;
            this.Sessions_DataGrid.AllowUserToDeleteRows = false;
            this.Sessions_DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.Sessions_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sessions_DataGrid.Location = new System.Drawing.Point(5, 5);
            this.Sessions_DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.Sessions_DataGrid.Name = "Sessions_DataGrid";
            this.Sessions_DataGrid.ReadOnly = true;
            this.Sessions_DataGrid.RowTemplate.Height = 33;
            this.Sessions_DataGrid.Size = new System.Drawing.Size(584, 310);
            this.Sessions_DataGrid.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 350);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Alarms_DataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarms report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sessions_DataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sessions report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.panel_header.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alarms_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sessions_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label label_copyRight;
        private System.Windows.Forms.DataGridView Alarms_DataGrid;
        private System.Windows.Forms.DataGridView Sessions_DataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}