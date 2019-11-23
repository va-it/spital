namespace spital
{
    partial class ModulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulesForm));
            this.modulesButton = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.groupBox_Modules = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Modules = new System.Windows.Forms.CheckedListBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.groupBox_Modules.SuspendLayout();
            this.SuspendLayout();
            // 
            // modulesButton
            // 
            this.modulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.modulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulesButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulesButton.ForeColor = System.Drawing.Color.White;
            this.modulesButton.Location = new System.Drawing.Point(366, 283);
            this.modulesButton.Margin = new System.Windows.Forms.Padding(2);
            this.modulesButton.Name = "modulesButton";
            this.modulesButton.Size = new System.Drawing.Size(107, 37);
            this.modulesButton.TabIndex = 7;
            this.modulesButton.Text = "Next";
            this.modulesButton.UseVisualStyleBackColor = false;
            this.modulesButton.Click += new System.EventHandler(this.modulesButton_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(501, 67);
            this.panelHeader.TabIndex = 10;
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "";
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(170, 67);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelFooter.Controls.Add(this.copyright);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 333);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(501, 33);
            this.panelFooter.TabIndex = 11;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(152, 7);
            this.copyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(195, 17);
            this.copyright.TabIndex = 0;
            this.copyright.Text = "© 2019 East Anglia Hospital trust";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Modules
            // 
            this.groupBox_Modules.Controls.Add(this.checkedListBox_Modules);
            this.groupBox_Modules.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Modules.Location = new System.Drawing.Point(23, 72);
            this.groupBox_Modules.Name = "groupBox_Modules";
            this.groupBox_Modules.Size = new System.Drawing.Size(450, 195);
            this.groupBox_Modules.TabIndex = 28;
            this.groupBox_Modules.TabStop = false;
            this.groupBox_Modules.Text = "Module Selection";
            // 
            // checkedListBox_Modules
            // 
            this.checkedListBox_Modules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Modules.CheckOnClick = true;
            this.checkedListBox_Modules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox_Modules.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Modules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkedListBox_Modules.FormattingEnabled = true;
            this.checkedListBox_Modules.HorizontalScrollbar = true;
            this.checkedListBox_Modules.Location = new System.Drawing.Point(12, 30);
            this.checkedListBox_Modules.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_Modules.Name = "checkedListBox_Modules";
            this.checkedListBox_Modules.Size = new System.Drawing.Size(433, 144);
            this.checkedListBox_Modules.TabIndex = 0;
            // 
            // ModulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 366);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.modulesButton);
            this.Controls.Add(this.groupBox_Modules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.ModulesForm_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.groupBox_Modules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button modulesButton;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.GroupBox groupBox_Modules;
        private System.Windows.Forms.CheckedListBox checkedListBox_Modules;
    }
}