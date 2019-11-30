namespace spital
{
    partial class UC_Bed
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
            this.label_BedNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_BedNumber
            // 
            this.label_BedNumber.AutoSize = true;
            this.label_BedNumber.Location = new System.Drawing.Point(4, 4);
            this.label_BedNumber.Name = "label_BedNumber";
            this.label_BedNumber.Size = new System.Drawing.Size(35, 13);
            this.label_BedNumber.TabIndex = 0;
            this.label_BedNumber.Text = "label1";
            // 
            // UC_Bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_BedNumber);
            this.Name = "UC_Bed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_BedNumber;
    }
}
