namespace spital
{
    partial class MonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorForm));
            this.groupBoxModule = new System.Windows.Forms.GroupBox();
            this.readingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.moduleName4 = new System.Windows.Forms.Label();
            this.moduleName3 = new System.Windows.Forms.Label();
            this.moduleName2 = new System.Windows.Forms.Label();
            this.moduleIcon1 = new System.Windows.Forms.PictureBox();
            this.moduleIcon2 = new System.Windows.Forms.PictureBox();
            this.moduleIcon3 = new System.Windows.Forms.PictureBox();
            this.moduleIcon4 = new System.Windows.Forms.PictureBox();
            this.moduleName1 = new System.Windows.Forms.Label();
            this.groupBoxLimits = new System.Windows.Forms.GroupBox();
            this.label_MaximumLimit = new System.Windows.Forms.Label();
            this.label_MinimumLimit = new System.Windows.Forms.Label();
            this.limitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.label_Module1Max = new System.Windows.Forms.Label();
            this.label_Module2Min = new System.Windows.Forms.Label();
            this.label_Module2Max = new System.Windows.Forms.Label();
            this.label_Module3Min = new System.Windows.Forms.Label();
            this.label_Module3Max = new System.Windows.Forms.Label();
            this.label_Module4Min = new System.Windows.Forms.Label();
            this.label_Module4Max = new System.Windows.Forms.Label();
            this.label_Module1Min = new System.Windows.Forms.Label();
            this.alarmButton = new System.Windows.Forms.Button();
            this.limitsButton = new System.Windows.Forms.Button();
            this.modulesButton = new System.Windows.Forms.Button();
            this.panelMonitorNumberContainer = new System.Windows.Forms.Panel();
            this.panelMonitorNumber = new System.Windows.Forms.Panel();
            this.monitorNumber = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.AlarmTextBox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.groupBoxReading = new System.Windows.Forms.GroupBox();
            this.tableReading = new System.Windows.Forms.TableLayoutPanel();
            this.label1reading = new System.Windows.Forms.Label();
            this.label2reading = new System.Windows.Forms.Label();
            this.label3reading = new System.Windows.Forms.Label();
            this.label4reading = new System.Windows.Forms.Label();
            this.groupBoxModule.SuspendLayout();
            this.readingsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon4)).BeginInit();
            this.groupBoxLimits.SuspendLayout();
            this.limitsTable.SuspendLayout();
            this.panelMonitorNumberContainer.SuspendLayout();
            this.panelMonitorNumber.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.groupBoxReading.SuspendLayout();
            this.tableReading.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModule
            // 
            this.groupBoxModule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxModule.Controls.Add(this.readingsTable);
            this.groupBoxModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxModule.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModule.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxModule.Location = new System.Drawing.Point(8, 90);
            this.groupBoxModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxModule.Name = "groupBoxModule";
            this.groupBoxModule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxModule.Size = new System.Drawing.Size(441, 325);
            this.groupBoxModule.TabIndex = 0;
            this.groupBoxModule.TabStop = false;
            this.groupBoxModule.Text = "Selected Modules";
            // 
            // readingsTable
            // 
            this.readingsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.readingsTable.ColumnCount = 2;
            this.readingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.readingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.readingsTable.Controls.Add(this.moduleName4, 1, 3);
            this.readingsTable.Controls.Add(this.moduleName3, 1, 2);
            this.readingsTable.Controls.Add(this.moduleName2, 1, 1);
            this.readingsTable.Controls.Add(this.moduleIcon1, 0, 0);
            this.readingsTable.Controls.Add(this.moduleIcon2, 0, 1);
            this.readingsTable.Controls.Add(this.moduleIcon3, 0, 2);
            this.readingsTable.Controls.Add(this.moduleIcon4, 0, 3);
            this.readingsTable.Controls.Add(this.moduleName1, 1, 0);
            this.readingsTable.Location = new System.Drawing.Point(9, 44);
            this.readingsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readingsTable.Name = "readingsTable";
            this.readingsTable.RowCount = 4;
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.Size = new System.Drawing.Size(428, 270);
            this.readingsTable.TabIndex = 0;
            // 
            // moduleName4
            // 
            this.moduleName4.AutoSize = true;
            this.moduleName4.BackColor = System.Drawing.SystemColors.Window;
            this.moduleName4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleName4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.moduleName4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduleName4.Location = new System.Drawing.Point(89, 202);
            this.moduleName4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleName4.Name = "moduleName4";
            this.moduleName4.Size = new System.Drawing.Size(336, 67);
            this.moduleName4.TabIndex = 7;
            this.moduleName4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moduleName3
            // 
            this.moduleName3.AutoSize = true;
            this.moduleName3.BackColor = System.Drawing.SystemColors.Window;
            this.moduleName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleName3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.moduleName3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduleName3.Location = new System.Drawing.Point(89, 135);
            this.moduleName3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleName3.Name = "moduleName3";
            this.moduleName3.Size = new System.Drawing.Size(336, 66);
            this.moduleName3.TabIndex = 6;
            this.moduleName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moduleName2
            // 
            this.moduleName2.AutoSize = true;
            this.moduleName2.BackColor = System.Drawing.SystemColors.Window;
            this.moduleName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleName2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.moduleName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduleName2.Location = new System.Drawing.Point(89, 68);
            this.moduleName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleName2.Name = "moduleName2";
            this.moduleName2.Size = new System.Drawing.Size(336, 66);
            this.moduleName2.TabIndex = 5;
            this.moduleName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moduleIcon1
            // 
            this.moduleIcon1.BackColor = System.Drawing.SystemColors.Window;
            this.moduleIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon1.Location = new System.Drawing.Point(3, 3);
            this.moduleIcon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon1.Name = "moduleIcon1";
            this.moduleIcon1.Size = new System.Drawing.Size(81, 62);
            this.moduleIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moduleIcon1.TabIndex = 0;
            this.moduleIcon1.TabStop = false;
            // 
            // moduleIcon2
            // 
            this.moduleIcon2.BackColor = System.Drawing.SystemColors.Window;
            this.moduleIcon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon2.Location = new System.Drawing.Point(3, 70);
            this.moduleIcon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon2.Name = "moduleIcon2";
            this.moduleIcon2.Size = new System.Drawing.Size(81, 62);
            this.moduleIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moduleIcon2.TabIndex = 1;
            this.moduleIcon2.TabStop = false;
            // 
            // moduleIcon3
            // 
            this.moduleIcon3.BackColor = System.Drawing.SystemColors.Window;
            this.moduleIcon3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon3.Location = new System.Drawing.Point(3, 137);
            this.moduleIcon3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon3.Name = "moduleIcon3";
            this.moduleIcon3.Size = new System.Drawing.Size(81, 62);
            this.moduleIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moduleIcon3.TabIndex = 2;
            this.moduleIcon3.TabStop = false;
            // 
            // moduleIcon4
            // 
            this.moduleIcon4.BackColor = System.Drawing.SystemColors.Window;
            this.moduleIcon4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon4.Location = new System.Drawing.Point(3, 204);
            this.moduleIcon4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon4.Name = "moduleIcon4";
            this.moduleIcon4.Size = new System.Drawing.Size(81, 63);
            this.moduleIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moduleIcon4.TabIndex = 3;
            this.moduleIcon4.TabStop = false;
            // 
            // moduleName1
            // 
            this.moduleName1.AutoSize = true;
            this.moduleName1.BackColor = System.Drawing.SystemColors.Window;
            this.moduleName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleName1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.moduleName1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduleName1.Location = new System.Drawing.Point(89, 1);
            this.moduleName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleName1.Name = "moduleName1";
            this.moduleName1.Size = new System.Drawing.Size(336, 66);
            this.moduleName1.TabIndex = 4;
            this.moduleName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxLimits
            // 
            this.groupBoxLimits.AccessibleDescription = "";
            this.groupBoxLimits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxLimits.Controls.Add(this.label_MaximumLimit);
            this.groupBoxLimits.Controls.Add(this.label_MinimumLimit);
            this.groupBoxLimits.Controls.Add(this.limitsTable);
            this.groupBoxLimits.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLimits.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxLimits.Location = new System.Drawing.Point(611, 90);
            this.groupBoxLimits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLimits.Name = "groupBoxLimits";
            this.groupBoxLimits.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLimits.Size = new System.Drawing.Size(256, 325);
            this.groupBoxLimits.TabIndex = 1;
            this.groupBoxLimits.TabStop = false;
            this.groupBoxLimits.Text = "Limits";
            // 
            // label_MaximumLimit
            // 
            this.label_MaximumLimit.AutoSize = true;
            this.label_MaximumLimit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaximumLimit.Location = new System.Drawing.Point(127, 26);
            this.label_MaximumLimit.Name = "label_MaximumLimit";
            this.label_MaximumLimit.Size = new System.Drawing.Size(89, 15);
            this.label_MaximumLimit.TabIndex = 2;
            this.label_MaximumLimit.Text = "Maximum Limit";
            // 
            // label_MinimumLimit
            // 
            this.label_MinimumLimit.AutoSize = true;
            this.label_MinimumLimit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MinimumLimit.Location = new System.Drawing.Point(13, 26);
            this.label_MinimumLimit.Name = "label_MinimumLimit";
            this.label_MinimumLimit.Size = new System.Drawing.Size(86, 15);
            this.label_MinimumLimit.TabIndex = 1;
            this.label_MinimumLimit.Text = "Minimum Limit";
            // 
            // limitsTable
            // 
            this.limitsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.limitsTable.ColumnCount = 2;
            this.limitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitsTable.Controls.Add(this.label_Module1Max, 1, 0);
            this.limitsTable.Controls.Add(this.label_Module2Min, 0, 1);
            this.limitsTable.Controls.Add(this.label_Module2Max, 1, 1);
            this.limitsTable.Controls.Add(this.label_Module3Min, 0, 2);
            this.limitsTable.Controls.Add(this.label_Module3Max, 1, 2);
            this.limitsTable.Controls.Add(this.label_Module4Min, 0, 3);
            this.limitsTable.Controls.Add(this.label_Module4Max, 1, 3);
            this.limitsTable.Controls.Add(this.label_Module1Min, 0, 0);
            this.limitsTable.Location = new System.Drawing.Point(16, 44);
            this.limitsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limitsTable.Name = "limitsTable";
            this.limitsTable.RowCount = 4;
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.Size = new System.Drawing.Size(226, 270);
            this.limitsTable.TabIndex = 0;
            // 
            // label_Module1Max
            // 
            this.label_Module1Max.AutoSize = true;
            this.label_Module1Max.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module1Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module1Max.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module1Max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module1Max.Location = new System.Drawing.Point(116, 1);
            this.label_Module1Max.Name = "label_Module1Max";
            this.label_Module1Max.Size = new System.Drawing.Size(106, 66);
            this.label_Module1Max.TabIndex = 1;
            this.label_Module1Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module2Min
            // 
            this.label_Module2Min.AutoSize = true;
            this.label_Module2Min.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module2Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module2Min.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module2Min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module2Min.Location = new System.Drawing.Point(4, 68);
            this.label_Module2Min.Name = "label_Module2Min";
            this.label_Module2Min.Size = new System.Drawing.Size(105, 66);
            this.label_Module2Min.TabIndex = 2;
            this.label_Module2Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module2Max
            // 
            this.label_Module2Max.AutoSize = true;
            this.label_Module2Max.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module2Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module2Max.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module2Max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module2Max.Location = new System.Drawing.Point(116, 68);
            this.label_Module2Max.Name = "label_Module2Max";
            this.label_Module2Max.Size = new System.Drawing.Size(106, 66);
            this.label_Module2Max.TabIndex = 3;
            this.label_Module2Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module3Min
            // 
            this.label_Module3Min.AutoSize = true;
            this.label_Module3Min.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module3Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module3Min.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module3Min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module3Min.Location = new System.Drawing.Point(4, 135);
            this.label_Module3Min.Name = "label_Module3Min";
            this.label_Module3Min.Size = new System.Drawing.Size(105, 66);
            this.label_Module3Min.TabIndex = 4;
            this.label_Module3Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module3Max
            // 
            this.label_Module3Max.AutoSize = true;
            this.label_Module3Max.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module3Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module3Max.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module3Max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module3Max.Location = new System.Drawing.Point(116, 135);
            this.label_Module3Max.Name = "label_Module3Max";
            this.label_Module3Max.Size = new System.Drawing.Size(106, 66);
            this.label_Module3Max.TabIndex = 5;
            this.label_Module3Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module4Min
            // 
            this.label_Module4Min.AutoSize = true;
            this.label_Module4Min.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module4Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module4Min.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module4Min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module4Min.Location = new System.Drawing.Point(4, 202);
            this.label_Module4Min.Name = "label_Module4Min";
            this.label_Module4Min.Size = new System.Drawing.Size(105, 67);
            this.label_Module4Min.TabIndex = 6;
            this.label_Module4Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module4Max
            // 
            this.label_Module4Max.AutoSize = true;
            this.label_Module4Max.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module4Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module4Max.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module4Max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module4Max.Location = new System.Drawing.Point(116, 202);
            this.label_Module4Max.Name = "label_Module4Max";
            this.label_Module4Max.Size = new System.Drawing.Size(106, 67);
            this.label_Module4Max.TabIndex = 7;
            this.label_Module4Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Module1Min
            // 
            this.label_Module1Min.AutoSize = true;
            this.label_Module1Min.BackColor = System.Drawing.SystemColors.Window;
            this.label_Module1Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Module1Min.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label_Module1Min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Module1Min.Location = new System.Drawing.Point(4, 1);
            this.label_Module1Min.Name = "label_Module1Min";
            this.label_Module1Min.Size = new System.Drawing.Size(105, 66);
            this.label_Module1Min.TabIndex = 0;
            this.label_Module1Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmButton
            // 
            this.alarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.alarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmButton.ForeColor = System.Drawing.Color.White;
            this.alarmButton.Location = new System.Drawing.Point(746, 26);
            this.alarmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(107, 37);
            this.alarmButton.TabIndex = 3;
            this.alarmButton.Text = "Stop Alarm";
            this.alarmButton.UseVisualStyleBackColor = false;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // limitsButton
            // 
            this.limitsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.limitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limitsButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitsButton.ForeColor = System.Drawing.Color.White;
            this.limitsButton.Location = new System.Drawing.Point(461, 430);
            this.limitsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limitsButton.Name = "limitsButton";
            this.limitsButton.Size = new System.Drawing.Size(107, 37);
            this.limitsButton.TabIndex = 4;
            this.limitsButton.Text = "Edit Limits";
            this.limitsButton.UseVisualStyleBackColor = false;
            this.limitsButton.Click += new System.EventHandler(this.limitsButton_Click);
            // 
            // modulesButton
            // 
            this.modulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.modulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulesButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulesButton.ForeColor = System.Drawing.Color.White;
            this.modulesButton.Location = new System.Drawing.Point(303, 430);
            this.modulesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modulesButton.Name = "modulesButton";
            this.modulesButton.Size = new System.Drawing.Size(107, 37);
            this.modulesButton.TabIndex = 6;
            this.modulesButton.Text = "Select Modules";
            this.modulesButton.UseVisualStyleBackColor = false;
            this.modulesButton.Click += new System.EventHandler(this.modulesButton_Click);
            // 
            // panelMonitorNumberContainer
            // 
            this.panelMonitorNumberContainer.BackColor = System.Drawing.Color.LightGray;
            this.panelMonitorNumberContainer.Controls.Add(this.panelMonitorNumber);
            this.panelMonitorNumberContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMonitorNumberContainer.Location = new System.Drawing.Point(191, 26);
            this.panelMonitorNumberContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMonitorNumberContainer.Name = "panelMonitorNumberContainer";
            this.panelMonitorNumberContainer.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelMonitorNumberContainer.Size = new System.Drawing.Size(30, 37);
            this.panelMonitorNumberContainer.TabIndex = 7;
            // 
            // panelMonitorNumber
            // 
            this.panelMonitorNumber.BackColor = System.Drawing.Color.White;
            this.panelMonitorNumber.Controls.Add(this.monitorNumber);
            this.panelMonitorNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitorNumber.Location = new System.Drawing.Point(1, 1);
            this.panelMonitorNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMonitorNumber.Name = "panelMonitorNumber";
            this.panelMonitorNumber.Size = new System.Drawing.Size(28, 35);
            this.panelMonitorNumber.TabIndex = 0;
            // 
            // monitorNumber
            // 
            this.monitorNumber.AutoSize = true;
            this.monitorNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorNumber.Location = new System.Drawing.Point(0, 0);
            this.monitorNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monitorNumber.Name = "monitorNumber";
            this.monitorNumber.Size = new System.Drawing.Size(0, 31);
            this.monitorNumber.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelHeader.Controls.Add(this.AlarmTextBox);
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Controls.Add(this.panelMonitorNumberContainer);
            this.panelHeader.Controls.Add(this.alarmButton);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 86);
            this.panelHeader.TabIndex = 9;
            // 
            // AlarmTextBox
            // 
            this.AlarmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTextBox.ForeColor = System.Drawing.Color.Red;
            this.AlarmTextBox.Location = new System.Drawing.Point(234, 26);
            this.AlarmTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlarmTextBox.Multiline = true;
            this.AlarmTextBox.Name = "AlarmTextBox";
            this.AlarmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AlarmTextBox.Size = new System.Drawing.Size(502, 38);
            this.AlarmTextBox.TabIndex = 8;
            this.AlarmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlarmTextBox.WordWrap = false;
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "";
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(8, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(170, 81);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelFooter.Controls.Add(this.copyright);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 476);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(880, 33);
            this.panelFooter.TabIndex = 10;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(343, 7);
            this.copyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(195, 17);
            this.copyright.TabIndex = 0;
            this.copyright.Text = "© 2019 East Anglia Hospital trust";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxReading
            // 
            this.groupBoxReading.AccessibleDescription = "";
            this.groupBoxReading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxReading.Controls.Add(this.tableReading);
            this.groupBoxReading.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReading.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxReading.Location = new System.Drawing.Point(457, 90);
            this.groupBoxReading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxReading.Name = "groupBoxReading";
            this.groupBoxReading.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxReading.Size = new System.Drawing.Size(150, 325);
            this.groupBoxReading.TabIndex = 11;
            this.groupBoxReading.TabStop = false;
            this.groupBoxReading.Text = "Reading";
            // 
            // tableReading
            // 
            this.tableReading.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableReading.ColumnCount = 1;
            this.tableReading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableReading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableReading.Controls.Add(this.label1reading, 0, 0);
            this.tableReading.Controls.Add(this.label2reading, 0, 1);
            this.tableReading.Controls.Add(this.label3reading, 0, 2);
            this.tableReading.Controls.Add(this.label4reading, 0, 3);
            this.tableReading.Location = new System.Drawing.Point(4, 44);
            this.tableReading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableReading.Name = "tableReading";
            this.tableReading.RowCount = 4;
            this.tableReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableReading.Size = new System.Drawing.Size(142, 270);
            this.tableReading.TabIndex = 0;
            // 
            // label1reading
            // 
            this.label1reading.AutoSize = true;
            this.label1reading.BackColor = System.Drawing.SystemColors.Window;
            this.label1reading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1reading.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1reading.Location = new System.Drawing.Point(3, 1);
            this.label1reading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1reading.Name = "label1reading";
            this.label1reading.Size = new System.Drawing.Size(136, 66);
            this.label1reading.TabIndex = 0;
            this.label1reading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2reading
            // 
            this.label2reading.AutoSize = true;
            this.label2reading.BackColor = System.Drawing.SystemColors.Window;
            this.label2reading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2reading.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2reading.Location = new System.Drawing.Point(3, 68);
            this.label2reading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2reading.Name = "label2reading";
            this.label2reading.Size = new System.Drawing.Size(136, 66);
            this.label2reading.TabIndex = 1;
            this.label2reading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3reading
            // 
            this.label3reading.AutoSize = true;
            this.label3reading.BackColor = System.Drawing.SystemColors.Window;
            this.label3reading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3reading.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3reading.Location = new System.Drawing.Point(3, 135);
            this.label3reading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3reading.Name = "label3reading";
            this.label3reading.Size = new System.Drawing.Size(136, 66);
            this.label3reading.TabIndex = 2;
            this.label3reading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4reading
            // 
            this.label4reading.AutoSize = true;
            this.label4reading.BackColor = System.Drawing.SystemColors.Window;
            this.label4reading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4reading.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4reading.Location = new System.Drawing.Point(3, 202);
            this.label4reading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4reading.Name = "label4reading";
            this.label4reading.Size = new System.Drawing.Size(136, 67);
            this.label4reading.TabIndex = 3;
            this.label4reading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 509);
            this.Controls.Add(this.groupBoxReading);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.modulesButton);
            this.Controls.Add(this.limitsButton);
            this.Controls.Add(this.groupBoxLimits);
            this.Controls.Add(this.groupBoxModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.groupBoxModule.ResumeLayout(false);
            this.readingsTable.ResumeLayout(false);
            this.readingsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon4)).EndInit();
            this.groupBoxLimits.ResumeLayout(false);
            this.groupBoxLimits.PerformLayout();
            this.limitsTable.ResumeLayout(false);
            this.limitsTable.PerformLayout();
            this.panelMonitorNumberContainer.ResumeLayout(false);
            this.panelMonitorNumber.ResumeLayout(false);
            this.panelMonitorNumber.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.groupBoxReading.ResumeLayout(false);
            this.tableReading.ResumeLayout(false);
            this.tableReading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModule;
        private System.Windows.Forms.GroupBox groupBoxLimits;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Button limitsButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TableLayoutPanel readingsTable;
        private System.Windows.Forms.PictureBox moduleIcon1;
        private System.Windows.Forms.PictureBox moduleIcon2;
        private System.Windows.Forms.PictureBox moduleIcon3;
        private System.Windows.Forms.PictureBox moduleIcon4;
        private System.Windows.Forms.Button modulesButton;
        private System.Windows.Forms.Panel panelMonitorNumberContainer;
        private System.Windows.Forms.Label monitorNumber;
        private System.Windows.Forms.Panel panelMonitorNumber;
        private System.Windows.Forms.Label moduleName4;
        private System.Windows.Forms.Label moduleName3;
        private System.Windows.Forms.Label moduleName2;
        private System.Windows.Forms.Label moduleName1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.GroupBox groupBoxReading;
        private System.Windows.Forms.TableLayoutPanel tableReading;
        private System.Windows.Forms.Label label_MaximumLimit;
        private System.Windows.Forms.Label label_MinimumLimit;
        private System.Windows.Forms.TableLayoutPanel limitsTable;
        private System.Windows.Forms.Label label_Module1Max;
        private System.Windows.Forms.Label label_Module2Min;
        private System.Windows.Forms.Label label_Module2Max;
        private System.Windows.Forms.Label label_Module3Min;
        private System.Windows.Forms.Label label_Module3Max;
        private System.Windows.Forms.Label label_Module4Min;
        private System.Windows.Forms.Label label_Module4Max;
        private System.Windows.Forms.Label label_Module1Min;
        private System.Windows.Forms.Label label1reading;
        private System.Windows.Forms.Label label2reading;
        private System.Windows.Forms.Label label3reading;
        private System.Windows.Forms.Label label4reading;
        private System.Windows.Forms.TextBox AlarmTextBox;
    }
}

