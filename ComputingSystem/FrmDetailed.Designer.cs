namespace ComputingSystem
{
    partial class FrmDetailed
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.tbDevice1 = new System.Windows.Forms.TextBox();
            this.lblintensity = new System.Windows.Forms.Label();
            this.lblMinBurstTime = new System.Windows.Forms.Label();
            this.lblMaxBurstTime = new System.Windows.Forms.Label();
            this.lblRamSize = new System.Windows.Forms.Label();
            this.lblMinAddrSpace = new System.Windows.Forms.Label();
            this.lblMaxAddrSpace = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblCpuQueue = new System.Windows.Forms.Label();
            this.lblDeviceQueue = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblFreeRamSize = new System.Windows.Forms.Label();
            this.lblOccupiedSize = new System.Windows.Forms.Label();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.lbCPUQueue = new System.Windows.Forms.ListBox();
            this.lbDeviceQueue1 = new System.Windows.Forms.ListBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnSessionEnd = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbProductivity = new System.Windows.Forms.TextBox();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.tbCpuUtil = new System.Windows.Forms.TextBox();
            this.hardCPU = new System.Windows.Forms.Label();
            this.tlPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFreeMemValue = new System.Windows.Forms.Label();
            this.lblOccupiedMemValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDeviceQueue3 = new System.Windows.Forms.ListBox();
            this.lblDevice2 = new System.Windows.Forms.Label();
            this.lblDeviceQueue2 = new System.Windows.Forms.Label();
            this.lbDeviceQueue2 = new System.Windows.Forms.ListBox();
            this.tbDevice2 = new System.Windows.Forms.TextBox();
            this.lblDevice3 = new System.Windows.Forms.Label();
            this.tbDevice3 = new System.Windows.Forms.TextBox();
            this.lblDeviceQueue3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.tlPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCPU
            // 
            this.tbCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCPU.Location = new System.Drawing.Point(3, 44);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.ReadOnly = true;
            this.tbCPU.Size = new System.Drawing.Size(342, 23);
            this.tbCPU.TabIndex = 2;
            // 
            // tbDevice1
            // 
            this.tbDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevice1.Location = new System.Drawing.Point(351, 44);
            this.tbDevice1.Name = "tbDevice1";
            this.tbDevice1.ReadOnly = true;
            this.tbDevice1.Size = new System.Drawing.Size(387, 23);
            this.tbDevice1.TabIndex = 3;
            // 
            // lblintensity
            // 
            this.lblintensity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblintensity.Location = new System.Drawing.Point(3, 0);
            this.lblintensity.Name = "lblintensity";
            this.lblintensity.Size = new System.Drawing.Size(248, 46);
            this.lblintensity.TabIndex = 20;
            this.lblintensity.Text = "Интенсивность поступления процессов";
            // 
            // lblMinBurstTime
            // 
            this.lblMinBurstTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinBurstTime.Location = new System.Drawing.Point(257, 0);
            this.lblMinBurstTime.Name = "lblMinBurstTime";
            this.lblMinBurstTime.Size = new System.Drawing.Size(248, 63);
            this.lblMinBurstTime.TabIndex = 21;
            this.lblMinBurstTime.Text = "Минимальное значение промежутка работы на ЦП";
            // 
            // lblMaxBurstTime
            // 
            this.lblMaxBurstTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxBurstTime.Location = new System.Drawing.Point(511, 0);
            this.lblMaxBurstTime.Name = "lblMaxBurstTime";
            this.lblMaxBurstTime.Size = new System.Drawing.Size(248, 63);
            this.lblMaxBurstTime.TabIndex = 22;
            this.lblMaxBurstTime.Text = "Максимальное значение промежутка работы на ЦП";
            // 
            // lblRamSize
            // 
            this.lblRamSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRamSize.Location = new System.Drawing.Point(765, 0);
            this.lblRamSize.Name = "lblRamSize";
            this.lblRamSize.Size = new System.Drawing.Size(248, 46);
            this.lblRamSize.TabIndex = 23;
            this.lblRamSize.Text = "Размер оперативной памяти";
            // 
            // lblMinAddrSpace
            // 
            this.lblMinAddrSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinAddrSpace.Location = new System.Drawing.Point(1019, 0);
            this.lblMinAddrSpace.Name = "lblMinAddrSpace";
            this.lblMinAddrSpace.Size = new System.Drawing.Size(233, 62);
            this.lblMinAddrSpace.TabIndex = 24;
            this.lblMinAddrSpace.Text = "Минимальный размер адресного пространства процесса ";
            // 
            // lblMaxAddrSpace
            // 
            this.lblMaxAddrSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaxAddrSpace.Location = new System.Drawing.Point(1258, 0);
            this.lblMaxAddrSpace.Name = "lblMaxAddrSpace";
            this.lblMaxAddrSpace.Size = new System.Drawing.Size(236, 62);
            this.lblMaxAddrSpace.TabIndex = 25;
            this.lblMaxAddrSpace.Text = "Максимальный размер адресного пространства процесса ";
            // 
            // lblCPU
            // 
            this.lblCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCPU.Location = new System.Drawing.Point(3, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(342, 15);
            this.lblCPU.TabIndex = 26;
            this.lblCPU.Text = "Центральный процессор";
            // 
            // lblDevice
            // 
            this.lblDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDevice.Location = new System.Drawing.Point(351, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(387, 15);
            this.lblDevice.TabIndex = 27;
            this.lblDevice.Text = "Внешнее устройство 1";
            // 
            // lblCpuQueue
            // 
            this.lblCpuQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCpuQueue.Location = new System.Drawing.Point(3, 75);
            this.lblCpuQueue.Name = "lblCpuQueue";
            this.lblCpuQueue.Size = new System.Drawing.Size(342, 16);
            this.lblCpuQueue.TabIndex = 28;
            this.lblCpuQueue.Text = "Очередь к центральному процессору";
            // 
            // lblDeviceQueue
            // 
            this.lblDeviceQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceQueue.Location = new System.Drawing.Point(351, 75);
            this.lblDeviceQueue.Name = "lblDeviceQueue";
            this.lblDeviceQueue.Size = new System.Drawing.Size(387, 25);
            this.lblDeviceQueue.TabIndex = 29;
            this.lblDeviceQueue.Text = "Очередь к внешнему устройству 1";
            // 
            // lblRam
            // 
            this.lblRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRam.Location = new System.Drawing.Point(3, 0);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(368, 20);
            this.lblRam.TabIndex = 30;
            this.lblRam.Text = "Оперативная память";
            // 
            // lblFreeRamSize
            // 
            this.lblFreeRamSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFreeRamSize.Location = new System.Drawing.Point(212, 23);
            this.lblFreeRamSize.Name = "lblFreeRamSize";
            this.lblFreeRamSize.Size = new System.Drawing.Size(159, 22);
            this.lblFreeRamSize.TabIndex = 31;
            this.lblFreeRamSize.Text = "Размер свободной памяти:";
            // 
            // lblOccupiedSize
            // 
            this.lblOccupiedSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOccupiedSize.Location = new System.Drawing.Point(902, 23);
            this.lblOccupiedSize.Name = "lblOccupiedSize";
            this.lblOccupiedSize.Size = new System.Drawing.Size(217, 22);
            this.lblOccupiedSize.TabIndex = 32;
            this.lblOccupiedSize.Text = "Размер памяти, занятой процессами:";
            // 
            // nudIntensity
            // 
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Location = new System.Drawing.Point(3, 71);
            this.nudIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(248, 23);
            this.nudIntensity.TabIndex = 21;
            this.nudIntensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMax.Location = new System.Drawing.Point(511, 71);
            this.nudBurstMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(248, 23);
            this.nudBurstMax.TabIndex = 23;
            this.nudBurstMax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbRamSize
            // 
            this.cbRamSize.AutoCompleteCustomSource.AddRange(new string[] {
            "32000",
            "64000"});
            this.cbRamSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRamSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "32000",
            "64000"});
            this.cbRamSize.Location = new System.Drawing.Point(765, 71);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(248, 23);
            this.cbRamSize.TabIndex = 24;
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(1019, 71);
            this.nudAddrSpaceMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(233, 23);
            this.nudAddrSpaceMin.TabIndex = 24;
            this.nudAddrSpaceMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(1258, 71);
            this.nudAddrSpaceMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(236, 23);
            this.nudAddrSpaceMax.TabIndex = 25;
            this.nudAddrSpaceMax.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // lbCPUQueue
            // 
            this.lbCPUQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCPUQueue.FormattingEnabled = true;
            this.lbCPUQueue.ItemHeight = 15;
            this.lbCPUQueue.Location = new System.Drawing.Point(3, 125);
            this.lbCPUQueue.Name = "lbCPUQueue";
            this.lbCPUQueue.Size = new System.Drawing.Size(342, 319);
            this.lbCPUQueue.TabIndex = 30;
            // 
            // lbDeviceQueue1
            // 
            this.lbDeviceQueue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue1.FormattingEnabled = true;
            this.lbDeviceQueue1.ItemHeight = 15;
            this.lbDeviceQueue1.Location = new System.Drawing.Point(351, 125);
            this.lbDeviceQueue1.Name = "lbDeviceQueue1";
            this.lbDeviceQueue1.Size = new System.Drawing.Size(387, 319);
            this.lbDeviceQueue1.TabIndex = 31;
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.rbAuto);
            this.pnlSettings.Controls.Add(this.rbManual);
            this.pnlSettings.Controls.Add(this.btnSessionEnd);
            this.pnlSettings.Controls.Add(this.lblMode);
            this.pnlSettings.Controls.Add(this.btnWork);
            this.pnlSettings.Controls.Add(this.lblTime);
            this.pnlSettings.Controls.Add(this.btnStart);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettings.Location = new System.Drawing.Point(0, 648);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1497, 52);
            this.pnlSettings.TabIndex = 33;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(166, 26);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(117, 19);
            this.rbAuto.TabIndex = 16;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(94, 26);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(66, 19);
            this.rbManual.TabIndex = 15;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // btnSessionEnd
            // 
            this.btnSessionEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSessionEnd.Location = new System.Drawing.Point(1361, 3);
            this.btnSessionEnd.Name = "btnSessionEnd";
            this.btnSessionEnd.Size = new System.Drawing.Size(129, 42);
            this.btnSessionEnd.TabIndex = 13;
            this.btnSessionEnd.Text = "Завершение сеанса";
            this.btnSessionEnd.UseVisualStyleBackColor = true;
            this.btnSessionEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            // 
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(94, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(91, 19);
            this.lblMode.TabIndex = 33;
            this.lblMode.Text = "Режим работы";
            // 
            // btnWork
            // 
            this.btnWork.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWork.Location = new System.Drawing.Point(1225, 3);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(130, 42);
            this.btnWork.TabIndex = 12;
            this.btnWork.Text = "Рабочий такт";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(1074, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 41);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Сохранение настроек";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbProductivity
            // 
            this.tbProductivity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductivity.Location = new System.Drawing.Point(1274, 55);
            this.tbProductivity.Name = "tbProductivity";
            this.tbProductivity.ReadOnly = true;
            this.tbProductivity.Size = new System.Drawing.Size(70, 23);
            this.tbProductivity.TabIndex = 38;
            // 
            // lblPerformance
            // 
            this.lblPerformance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Location = new System.Drawing.Point(996, 59);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(123, 15);
            this.lblPerformance.TabIndex = 37;
            this.lblPerformance.Text = "Производительность";
            // 
            // tbCpuUtil
            // 
            this.tbCpuUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCpuUtil.Location = new System.Drawing.Point(526, 55);
            this.tbCpuUtil.Name = "tbCpuUtil";
            this.tbCpuUtil.ReadOnly = true;
            this.tbCpuUtil.Size = new System.Drawing.Size(70, 23);
            this.tbCpuUtil.TabIndex = 36;
            // 
            // hardCPU
            // 
            this.hardCPU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hardCPU.AutoSize = true;
            this.hardCPU.Location = new System.Drawing.Point(211, 59);
            this.hardCPU.Name = "hardCPU";
            this.hardCPU.Size = new System.Drawing.Size(160, 15);
            this.hardCPU.TabIndex = 35;
            this.hardCPU.Text = "Загруженность процессора";
            // 
            // tlPanelSettings
            // 
            this.tlPanelSettings.ColumnCount = 6;
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlPanelSettings.Controls.Add(this.nudAddrSpaceMax, 5, 1);
            this.tlPanelSettings.Controls.Add(this.nudAddrSpaceMin, 4, 1);
            this.tlPanelSettings.Controls.Add(this.lblMaxAddrSpace, 5, 0);
            this.tlPanelSettings.Controls.Add(this.lblMinAddrSpace, 4, 0);
            this.tlPanelSettings.Controls.Add(this.cbRamSize, 3, 1);
            this.tlPanelSettings.Controls.Add(this.nudBurstMax, 2, 1);
            this.tlPanelSettings.Controls.Add(this.lblRamSize, 3, 0);
            this.tlPanelSettings.Controls.Add(this.lblMaxBurstTime, 2, 0);
            this.tlPanelSettings.Controls.Add(this.nudIntensity, 0, 1);
            this.tlPanelSettings.Controls.Add(this.lblMinBurstTime, 1, 0);
            this.tlPanelSettings.Controls.Add(this.lblintensity, 0, 0);
            this.tlPanelSettings.Controls.Add(this.nudBurstMin, 1, 1);
            this.tlPanelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlPanelSettings.Location = new System.Drawing.Point(0, 0);
            this.tlPanelSettings.Name = "tlPanelSettings";
            this.tlPanelSettings.RowCount = 2;
            this.tlPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.76471F));
            this.tlPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.23529F));
            this.tlPanelSettings.Size = new System.Drawing.Size(1497, 95);
            this.tlPanelSettings.TabIndex = 46;
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMin.Location = new System.Drawing.Point(257, 71);
            this.nudBurstMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(248, 23);
            this.nudBurstMin.TabIndex = 24;
            this.nudBurstMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tbProductivity, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFreeRamSize, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPerformance, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRam, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbCpuUtil, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.hardCPU, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFreeMemValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOccupiedMemValue, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOccupiedSize, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 564);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1497, 84);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // lblFreeMemValue
            // 
            this.lblFreeMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFreeMemValue.AutoSize = true;
            this.lblFreeMemValue.Location = new System.Drawing.Point(554, 27);
            this.lblFreeMemValue.Name = "lblFreeMemValue";
            this.lblFreeMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblFreeMemValue.TabIndex = 33;
            this.lblFreeMemValue.Text = "0";
            // 
            // lblOccupiedMemValue
            // 
            this.lblOccupiedMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOccupiedMemValue.AutoSize = true;
            this.lblOccupiedMemValue.Location = new System.Drawing.Point(1303, 27);
            this.lblOccupiedMemValue.Name = "lblOccupiedMemValue";
            this.lblOccupiedMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblOccupiedMemValue.TabIndex = 34;
            this.lblOccupiedMemValue.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.89669F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.91179F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.16899F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue3, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbCPUQueue, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCpuQueue, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDevice, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbCPU, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCPU, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDeviceQueue, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDevice2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDeviceQueue2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDevice3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice3, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDeviceQueue3, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.172259F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.606264F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51454F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.02381F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1497, 469);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // lbDeviceQueue3
            // 
            this.lbDeviceQueue3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue3.FormattingEnabled = true;
            this.lbDeviceQueue3.ItemHeight = 15;
            this.lbDeviceQueue3.Location = new System.Drawing.Point(1129, 125);
            this.lbDeviceQueue3.Name = "lbDeviceQueue3";
            this.lbDeviceQueue3.Size = new System.Drawing.Size(365, 319);
            this.lbDeviceQueue3.TabIndex = 36;
            // 
            // lblDevice2
            // 
            this.lblDevice2.AutoSize = true;
            this.lblDevice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevice2.Location = new System.Drawing.Point(744, 0);
            this.lblDevice2.Name = "lblDevice2";
            this.lblDevice2.Size = new System.Drawing.Size(379, 41);
            this.lblDevice2.TabIndex = 32;
            this.lblDevice2.Text = "Внешнее устройство 2";
            // 
            // lblDeviceQueue2
            // 
            this.lblDeviceQueue2.AutoSize = true;
            this.lblDeviceQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceQueue2.Location = new System.Drawing.Point(744, 75);
            this.lblDeviceQueue2.Name = "lblDeviceQueue2";
            this.lblDeviceQueue2.Size = new System.Drawing.Size(379, 47);
            this.lblDeviceQueue2.TabIndex = 33;
            this.lblDeviceQueue2.Text = "Очередь к внешнему устройству 2";
            // 
            // lbDeviceQueue2
            // 
            this.lbDeviceQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue2.FormattingEnabled = true;
            this.lbDeviceQueue2.ItemHeight = 15;
            this.lbDeviceQueue2.Location = new System.Drawing.Point(744, 125);
            this.lbDeviceQueue2.Name = "lbDeviceQueue2";
            this.lbDeviceQueue2.Size = new System.Drawing.Size(379, 319);
            this.lbDeviceQueue2.TabIndex = 34;
            // 
            // tbDevice2
            // 
            this.tbDevice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevice2.Location = new System.Drawing.Point(744, 44);
            this.tbDevice2.Name = "tbDevice2";
            this.tbDevice2.ReadOnly = true;
            this.tbDevice2.Size = new System.Drawing.Size(379, 23);
            this.tbDevice2.TabIndex = 35;
            // 
            // lblDevice3
            // 
            this.lblDevice3.AutoSize = true;
            this.lblDevice3.Location = new System.Drawing.Point(1129, 0);
            this.lblDevice3.Name = "lblDevice3";
            this.lblDevice3.Size = new System.Drawing.Size(131, 15);
            this.lblDevice3.TabIndex = 37;
            this.lblDevice3.Text = "Внешнее устройство 3";
            // 
            // tbDevice3
            // 
            this.tbDevice3.Location = new System.Drawing.Point(1129, 44);
            this.tbDevice3.Name = "tbDevice3";
            this.tbDevice3.ReadOnly = true;
            this.tbDevice3.Size = new System.Drawing.Size(365, 23);
            this.tbDevice3.TabIndex = 38;
            // 
            // lblDeviceQueue3
            // 
            this.lblDeviceQueue3.AutoSize = true;
            this.lblDeviceQueue3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceQueue3.Location = new System.Drawing.Point(1129, 75);
            this.lblDeviceQueue3.Name = "lblDeviceQueue3";
            this.lblDeviceQueue3.Size = new System.Drawing.Size(365, 47);
            this.lblDeviceQueue3.TabIndex = 39;
            this.lblDeviceQueue3.Text = "Очередь к внешнему устройству 3";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.btnWork_Click);
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1497, 700);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlPanelSettings);
            this.Controls.Add(this.pnlSettings);
            this.MinimumSize = new System.Drawing.Size(910, 606);
            this.Name = "FrmDetailed";
            this.Text = "Системное программное обеспечение: курсовая работа";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.tlPanelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.TextBox tbDevice1;
        private System.Windows.Forms.Label lblintensity;
        private System.Windows.Forms.Label lblMinBurstTime;
        private System.Windows.Forms.Label lblMaxBurstTime;
        private System.Windows.Forms.Label lblRamSize;
        private System.Windows.Forms.Label lblMinAddrSpace;
        private System.Windows.Forms.Label lblMaxAddrSpace;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblCpuQueue;
        private System.Windows.Forms.Label lblDeviceQueue;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblFreeRamSize;
        private System.Windows.Forms.Label lblOccupiedSize;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.ListBox lbCPUQueue;
        private System.Windows.Forms.ListBox lbDeviceQueue1;
        private System.Windows.Forms.NumericUpDown nudIntensity;

        private System.Windows.Forms.NumericUpDown nudAddrSpaceMax;
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMin;
        private System.Windows.Forms.NumericUpDown nudBurstMax;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btnSessionEnd;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tlPanelSettings;
        private System.Windows.Forms.NumericUpDown nudBurstMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFreeMemValue;
        private System.Windows.Forms.Label lblOccupiedMemValue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDevice2;
        private System.Windows.Forms.Label lblDeviceQueue2;
        private System.Windows.Forms.ListBox lbDeviceQueue2;
        private System.Windows.Forms.TextBox tbDevice2;
        private System.Windows.Forms.TextBox tbCpuUtil;
        private System.Windows.Forms.Label hardCPU;
        private System.Windows.Forms.TextBox tbProductivity;
        private System.Windows.Forms.Label lblPerformance;
        private ListBox lbDeviceQueue3;
        private Label lblDevice3;
        private TextBox tbDevice3;
        private Label lblDeviceQueue3;
    }
}

