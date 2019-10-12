namespace spital
{
    partial class Modules
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
            this.modulesList = new System.Windows.Forms.CheckedListBox();
            this.modulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modulesList
            // 
            this.modulesList.FormattingEnabled = true;
            this.modulesList.Location = new System.Drawing.Point(12, 12);
            this.modulesList.Name = "modulesList";
            this.modulesList.Size = new System.Drawing.Size(704, 424);
            this.modulesList.TabIndex = 0;
            // 
            // modulesButton
            // 
            this.modulesButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.modulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulesButton.ForeColor = System.Drawing.Color.White;
            this.modulesButton.Location = new System.Drawing.Point(566, 442);
            this.modulesButton.Name = "modulesButton";
            this.modulesButton.Size = new System.Drawing.Size(150, 57);
            this.modulesButton.TabIndex = 7;
            this.modulesButton.Text = "Next";
            this.modulesButton.UseVisualStyleBackColor = false;
            this.modulesButton.Click += new System.EventHandler(this.modulesButton_Click);
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 504);
            this.Controls.Add(this.modulesButton);
            this.Controls.Add(this.modulesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox modulesList;
        private System.Windows.Forms.Button modulesButton;
    }
}