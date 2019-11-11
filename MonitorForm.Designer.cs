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
            this.groupBoxReadings = new System.Windows.Forms.GroupBox();
            this.readingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.moduleReading4 = new System.Windows.Forms.Label();
            this.moduleReading3 = new System.Windows.Forms.Label();
            this.moduleReading2 = new System.Windows.Forms.Label();
            this.moduleIcon1 = new System.Windows.Forms.PictureBox();
            this.moduleIcon2 = new System.Windows.Forms.PictureBox();
            this.moduleIcon3 = new System.Windows.Forms.PictureBox();
            this.moduleIcon4 = new System.Windows.Forms.PictureBox();
            this.moduleReading1 = new System.Windows.Forms.Label();
            this.groupBoxLimits = new System.Windows.Forms.GroupBox();
            this.limitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.maxLimitModule4 = new System.Windows.Forms.Label();
            this.minLimitModule4 = new System.Windows.Forms.Label();
            this.maxLimitModule3 = new System.Windows.Forms.Label();
            this.minLimitModule3 = new System.Windows.Forms.Label();
            this.maxLimitModule2 = new System.Windows.Forms.Label();
            this.minLimitModule2 = new System.Windows.Forms.Label();
            this.maxLimitModule1 = new System.Windows.Forms.Label();
            this.minLimitModule1 = new System.Windows.Forms.Label();
            this.alarmButton = new System.Windows.Forms.Button();
            this.limitsButton = new System.Windows.Forms.Button();
            this.modulesButton = new System.Windows.Forms.Button();
            this.panelMonitorNumberContainer = new System.Windows.Forms.Panel();
            this.panelMonitorNumber = new System.Windows.Forms.Panel();
            this.monitorNumber = new System.Windows.Forms.Label();
            this.panelAlertMessageContainer = new System.Windows.Forms.Panel();
            this.panelAlertMessage = new System.Windows.Forms.Panel();
            this.alertMessage = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.groupBoxReadings.SuspendLayout();
            this.readingsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon4)).BeginInit();
            this.groupBoxLimits.SuspendLayout();
            this.limitsTable.SuspendLayout();
            this.panelMonitorNumberContainer.SuspendLayout();
            this.panelMonitorNumber.SuspendLayout();
            this.panelAlertMessageContainer.SuspendLayout();
            this.panelAlertMessage.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReadings
            // 
            this.groupBoxReadings.Controls.Add(this.readingsTable);
            this.groupBoxReadings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxReadings.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReadings.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxReadings.Location = new System.Drawing.Point(8, 86);
            this.groupBoxReadings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxReadings.Name = "groupBoxReadings";
            this.groupBoxReadings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxReadings.Size = new System.Drawing.Size(446, 255);
            this.groupBoxReadings.TabIndex = 0;
            this.groupBoxReadings.TabStop = false;
            this.groupBoxReadings.Text = "Readings";
            // 
            // readingsTable
            // 
            this.readingsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.readingsTable.ColumnCount = 2;
            this.readingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.readingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.readingsTable.Controls.Add(this.moduleReading4, 1, 3);
            this.readingsTable.Controls.Add(this.moduleReading3, 1, 2);
            this.readingsTable.Controls.Add(this.moduleReading2, 1, 1);
            this.readingsTable.Controls.Add(this.moduleIcon1, 0, 0);
            this.readingsTable.Controls.Add(this.moduleIcon2, 0, 1);
            this.readingsTable.Controls.Add(this.moduleIcon3, 0, 2);
            this.readingsTable.Controls.Add(this.moduleIcon4, 0, 3);
            this.readingsTable.Controls.Add(this.moduleReading1, 1, 0);
            this.readingsTable.Location = new System.Drawing.Point(8, 20);
            this.readingsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readingsTable.Name = "readingsTable";
            this.readingsTable.RowCount = 4;
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.readingsTable.Size = new System.Drawing.Size(430, 227);
            this.readingsTable.TabIndex = 0;
            // 
            // moduleReading4
            // 
            this.moduleReading4.AutoSize = true;
            this.moduleReading4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleReading4.Location = new System.Drawing.Point(89, 169);
            this.moduleReading4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleReading4.Name = "moduleReading4";
            this.moduleReading4.Size = new System.Drawing.Size(338, 57);
            this.moduleReading4.TabIndex = 7;
            // 
            // moduleReading3
            // 
            this.moduleReading3.AutoSize = true;
            this.moduleReading3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleReading3.Location = new System.Drawing.Point(89, 113);
            this.moduleReading3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleReading3.Name = "moduleReading3";
            this.moduleReading3.Size = new System.Drawing.Size(338, 55);
            this.moduleReading3.TabIndex = 6;
            // 
            // moduleReading2
            // 
            this.moduleReading2.AutoSize = true;
            this.moduleReading2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleReading2.Location = new System.Drawing.Point(89, 57);
            this.moduleReading2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleReading2.Name = "moduleReading2";
            this.moduleReading2.Size = new System.Drawing.Size(338, 55);
            this.moduleReading2.TabIndex = 5;
            // 
            // moduleIcon1
            // 
            this.moduleIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon1.Location = new System.Drawing.Point(3, 3);
            this.moduleIcon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon1.Name = "moduleIcon1";
            this.moduleIcon1.Size = new System.Drawing.Size(81, 51);
            this.moduleIcon1.TabIndex = 0;
            this.moduleIcon1.TabStop = false;
            // 
            // moduleIcon2
            // 
            this.moduleIcon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon2.Location = new System.Drawing.Point(3, 59);
            this.moduleIcon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon2.Name = "moduleIcon2";
            this.moduleIcon2.Size = new System.Drawing.Size(81, 51);
            this.moduleIcon2.TabIndex = 1;
            this.moduleIcon2.TabStop = false;
            // 
            // moduleIcon3
            // 
            this.moduleIcon3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon3.Location = new System.Drawing.Point(3, 115);
            this.moduleIcon3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon3.Name = "moduleIcon3";
            this.moduleIcon3.Size = new System.Drawing.Size(81, 51);
            this.moduleIcon3.TabIndex = 2;
            this.moduleIcon3.TabStop = false;
            // 
            // moduleIcon4
            // 
            this.moduleIcon4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleIcon4.Location = new System.Drawing.Point(3, 171);
            this.moduleIcon4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moduleIcon4.Name = "moduleIcon4";
            this.moduleIcon4.Size = new System.Drawing.Size(81, 53);
            this.moduleIcon4.TabIndex = 3;
            this.moduleIcon4.TabStop = false;
            // 
            // moduleReading1
            // 
            this.moduleReading1.AutoSize = true;
            this.moduleReading1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleReading1.Location = new System.Drawing.Point(89, 1);
            this.moduleReading1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleReading1.Name = "moduleReading1";
            this.moduleReading1.Size = new System.Drawing.Size(338, 55);
            this.moduleReading1.TabIndex = 4;
            // 
            // groupBoxLimits
            // 
            this.groupBoxLimits.AccessibleDescription = "";
            this.groupBoxLimits.Controls.Add(this.limitsTable);
            this.groupBoxLimits.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLimits.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxLimits.Location = new System.Drawing.Point(458, 86);
            this.groupBoxLimits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLimits.Name = "groupBoxLimits";
            this.groupBoxLimits.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLimits.Size = new System.Drawing.Size(353, 255);
            this.groupBoxLimits.TabIndex = 1;
            this.groupBoxLimits.TabStop = false;
            this.groupBoxLimits.Text = "Limits";
            // 
            // limitsTable
            // 
            this.limitsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.limitsTable.ColumnCount = 2;
            this.limitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitsTable.Controls.Add(this.maxLimitModule4, 1, 3);
            this.limitsTable.Controls.Add(this.minLimitModule4, 0, 3);
            this.limitsTable.Controls.Add(this.maxLimitModule3, 1, 2);
            this.limitsTable.Controls.Add(this.minLimitModule3, 0, 2);
            this.limitsTable.Controls.Add(this.maxLimitModule2, 1, 1);
            this.limitsTable.Controls.Add(this.minLimitModule2, 0, 1);
            this.limitsTable.Controls.Add(this.maxLimitModule1, 1, 0);
            this.limitsTable.Controls.Add(this.minLimitModule1, 0, 0);
            this.limitsTable.Location = new System.Drawing.Point(7, 20);
            this.limitsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limitsTable.Name = "limitsTable";
            this.limitsTable.RowCount = 4;
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.limitsTable.Size = new System.Drawing.Size(339, 227);
            this.limitsTable.TabIndex = 0;
            // 
            // maxLimitModule4
            // 
            this.maxLimitModule4.AutoSize = true;
            this.maxLimitModule4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLimitModule4.Location = new System.Drawing.Point(172, 169);
            this.maxLimitModule4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLimitModule4.Name = "maxLimitModule4";
            this.maxLimitModule4.Size = new System.Drawing.Size(164, 57);
            this.maxLimitModule4.TabIndex = 7;
            // 
            // minLimitModule4
            // 
            this.minLimitModule4.AutoSize = true;
            this.minLimitModule4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLimitModule4.Location = new System.Drawing.Point(3, 169);
            this.minLimitModule4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLimitModule4.Name = "minLimitModule4";
            this.minLimitModule4.Size = new System.Drawing.Size(164, 57);
            this.minLimitModule4.TabIndex = 6;
            // 
            // maxLimitModule3
            // 
            this.maxLimitModule3.AutoSize = true;
            this.maxLimitModule3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLimitModule3.Location = new System.Drawing.Point(172, 113);
            this.maxLimitModule3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLimitModule3.Name = "maxLimitModule3";
            this.maxLimitModule3.Size = new System.Drawing.Size(164, 55);
            this.maxLimitModule3.TabIndex = 5;
            // 
            // minLimitModule3
            // 
            this.minLimitModule3.AutoSize = true;
            this.minLimitModule3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLimitModule3.Location = new System.Drawing.Point(3, 113);
            this.minLimitModule3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLimitModule3.Name = "minLimitModule3";
            this.minLimitModule3.Size = new System.Drawing.Size(164, 55);
            this.minLimitModule3.TabIndex = 4;
            // 
            // maxLimitModule2
            // 
            this.maxLimitModule2.AutoSize = true;
            this.maxLimitModule2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLimitModule2.Location = new System.Drawing.Point(172, 57);
            this.maxLimitModule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLimitModule2.Name = "maxLimitModule2";
            this.maxLimitModule2.Size = new System.Drawing.Size(164, 55);
            this.maxLimitModule2.TabIndex = 3;
            // 
            // minLimitModule2
            // 
            this.minLimitModule2.AutoSize = true;
            this.minLimitModule2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLimitModule2.Location = new System.Drawing.Point(3, 57);
            this.minLimitModule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLimitModule2.Name = "minLimitModule2";
            this.minLimitModule2.Size = new System.Drawing.Size(164, 55);
            this.minLimitModule2.TabIndex = 2;
            // 
            // maxLimitModule1
            // 
            this.maxLimitModule1.AutoSize = true;
            this.maxLimitModule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLimitModule1.Location = new System.Drawing.Point(172, 1);
            this.maxLimitModule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLimitModule1.Name = "maxLimitModule1";
            this.maxLimitModule1.Size = new System.Drawing.Size(164, 55);
            this.maxLimitModule1.TabIndex = 1;
            // 
            // minLimitModule1
            // 
            this.minLimitModule1.AutoSize = true;
            this.minLimitModule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minLimitModule1.Location = new System.Drawing.Point(3, 1);
            this.minLimitModule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLimitModule1.Name = "minLimitModule1";
            this.minLimitModule1.Size = new System.Drawing.Size(164, 55);
            this.minLimitModule1.TabIndex = 0;
            // 
            // alarmButton
            // 
            this.alarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.alarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmButton.ForeColor = System.Drawing.Color.White;
            this.alarmButton.Location = new System.Drawing.Point(701, 27);
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
            this.limitsButton.Location = new System.Drawing.Point(583, 346);
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
            this.modulesButton.Location = new System.Drawing.Point(183, 346);
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
            this.panelMonitorNumberContainer.Location = new System.Drawing.Point(183, 27);
            this.panelMonitorNumberContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMonitorNumberContainer.Name = "panelMonitorNumberContainer";
            this.panelMonitorNumberContainer.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelMonitorNumberContainer.Size = new System.Drawing.Size(48, 37);
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
            this.panelMonitorNumber.Size = new System.Drawing.Size(46, 35);
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
            // panelAlertMessageContainer
            // 
            this.panelAlertMessageContainer.BackColor = System.Drawing.Color.LightGray;
            this.panelAlertMessageContainer.Controls.Add(this.panelAlertMessage);
            this.panelAlertMessageContainer.ForeColor = System.Drawing.Color.Red;
            this.panelAlertMessageContainer.Location = new System.Drawing.Point(235, 27);
            this.panelAlertMessageContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAlertMessageContainer.Name = "panelAlertMessageContainer";
            this.panelAlertMessageContainer.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelAlertMessageContainer.Size = new System.Drawing.Size(461, 37);
            this.panelAlertMessageContainer.TabIndex = 8;
            // 
            // panelAlertMessage
            // 
            this.panelAlertMessage.BackColor = System.Drawing.Color.White;
            this.panelAlertMessage.Controls.Add(this.alertMessage);
            this.panelAlertMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlertMessage.Location = new System.Drawing.Point(1, 1);
            this.panelAlertMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAlertMessage.Name = "panelAlertMessage";
            this.panelAlertMessage.Size = new System.Drawing.Size(459, 35);
            this.panelAlertMessage.TabIndex = 2;
            // 
            // alertMessage
            // 
            this.alertMessage.AutoSize = true;
            this.alertMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertMessage.Location = new System.Drawing.Point(0, 0);
            this.alertMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertMessage.Name = "alertMessage";
            this.alertMessage.Size = new System.Drawing.Size(0, 31);
            this.alertMessage.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Controls.Add(this.panelAlertMessageContainer);
            this.panelHeader.Controls.Add(this.panelMonitorNumberContainer);
            this.panelHeader.Controls.Add(this.alarmButton);
            this.panelHeader.Location = new System.Drawing.Point(0, -1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(819, 86);
            this.panelHeader.TabIndex = 9;
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
            this.panelFooter.Location = new System.Drawing.Point(0, 387);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(819, 33);
            this.panelFooter.TabIndex = 10;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(339, 11);
            this.copyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(195, 17);
            this.copyright.TabIndex = 0;
            this.copyright.Text = "© 2019 East Anglia Hospital trust";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(819, 419);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.modulesButton);
            this.Controls.Add(this.limitsButton);
            this.Controls.Add(this.groupBoxLimits);
            this.Controls.Add(this.groupBoxReadings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.groupBoxReadings.ResumeLayout(false);
            this.readingsTable.ResumeLayout(false);
            this.readingsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleIcon4)).EndInit();
            this.groupBoxLimits.ResumeLayout(false);
            this.limitsTable.ResumeLayout(false);
            this.limitsTable.PerformLayout();
            this.panelMonitorNumberContainer.ResumeLayout(false);
            this.panelMonitorNumber.ResumeLayout(false);
            this.panelMonitorNumber.PerformLayout();
            this.panelAlertMessageContainer.ResumeLayout(false);
            this.panelAlertMessage.ResumeLayout(false);
            this.panelAlertMessage.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReadings;
        private System.Windows.Forms.GroupBox groupBoxLimits;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Button limitsButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TableLayoutPanel readingsTable;
        private System.Windows.Forms.TableLayoutPanel limitsTable;
        private System.Windows.Forms.PictureBox moduleIcon1;
        private System.Windows.Forms.PictureBox moduleIcon2;
        private System.Windows.Forms.PictureBox moduleIcon3;
        private System.Windows.Forms.PictureBox moduleIcon4;
        private System.Windows.Forms.Button modulesButton;
        private System.Windows.Forms.Panel panelMonitorNumberContainer;
        private System.Windows.Forms.Panel panelAlertMessageContainer;
        private System.Windows.Forms.Label monitorNumber;
        private System.Windows.Forms.Label alertMessage;
        private System.Windows.Forms.Panel panelAlertMessage;
        private System.Windows.Forms.Panel panelMonitorNumber;
        private System.Windows.Forms.Label moduleReading4;
        private System.Windows.Forms.Label moduleReading3;
        private System.Windows.Forms.Label moduleReading2;
        private System.Windows.Forms.Label moduleReading1;
        private System.Windows.Forms.Label maxLimitModule4;
        private System.Windows.Forms.Label minLimitModule4;
        private System.Windows.Forms.Label maxLimitModule3;
        private System.Windows.Forms.Label minLimitModule3;
        private System.Windows.Forms.Label maxLimitModule2;
        private System.Windows.Forms.Label minLimitModule2;
        private System.Windows.Forms.Label maxLimitModule1;
        private System.Windows.Forms.Label minLimitModule1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label copyright;
    }
}

