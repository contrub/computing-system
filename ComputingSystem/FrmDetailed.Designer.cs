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
            this.lbDeviceQueue = new System.Windows.Forms.ListBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.tbDevice = new System.Windows.Forms.TextBox();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.autoMode = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFreeMemValue = new System.Windows.Forms.TextBox();
            this.lblOccupatedMemValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbCPUQueue = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDeviceQueue
            // 
            this.lbDeviceQueue.ItemHeight = 15;
            this.lbDeviceQueue.Location = new System.Drawing.Point(9, 20);
            this.lbDeviceQueue.Name = "lbDeviceQueue";
            this.lbDeviceQueue.Size = new System.Drawing.Size(378, 154);
            this.lbDeviceQueue.TabIndex = 1;
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(3, 21);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.ReadOnly = true;
            this.tbCPU.Size = new System.Drawing.Size(378, 23);
            this.tbCPU.TabIndex = 2;
            // 
            // tbDevice
            // 
            this.tbDevice.Location = new System.Drawing.Point(4, 24);
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.ReadOnly = true;
            this.tbDevice.Size = new System.Drawing.Size(378, 23);
            this.tbDevice.TabIndex = 3;
            // 
            // nudIntensity
            // 
            this.nudIntensity.Location = new System.Drawing.Point(6, 77);
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(122, 23);
            this.nudIntensity.TabIndex = 5;
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Location = new System.Drawing.Point(4, 77);
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(122, 23);
            this.nudBurstMin.TabIndex = 6;
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.Location = new System.Drawing.Point(4, 77);
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(122, 23);
            this.nudBurstMax.TabIndex = 7;
            // 
            // cbRamSize
            // 
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[]
            {
                "4000",
                "8000",
                "16000",
                "32000",
                "64000"
            });
            this.cbRamSize.Location = new System.Drawing.Point(2, 77);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(122, 23);
            this.cbRamSize.TabIndex = 8;
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(5, 77);
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(122, 23);
            this.nudAddrSpaceMin.TabIndex = 9;
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(6, 77);
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(122, 23);
            this.nudAddrSpaceMax.TabIndex = 10;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(332, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 43);
            this.save.TabIndex = 11;
            this.save.Text = "Preservation\r\nsettings";
            this.save.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(447, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 42);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Working cycle";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.workingCycle_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(563, 13);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(105, 42);
            this.end.TabIndex = 13;
            this.end.Text = "Completion\r\nsession";
            this.end.UseVisualStyleBackColor = true;
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(674, 12);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(102, 42);
            this.statistics.TabIndex = 14;
            this.statistics.Text = "Statistics";
            this.statistics.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(100, 36);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(65, 19);
            this.rbManual.TabIndex = 15;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // autoMode
            // 
            this.autoMode.AutoSize = true;
            this.autoMode.Location = new System.Drawing.Point(172, 36);
            this.autoMode.Name = "autoMode";
            this.autoMode.Size = new System.Drawing.Size(51, 19);
            this.autoMode.TabIndex = 16;
            this.autoMode.TabStop = true;
            this.autoMode.Text = "Auto";
            this.autoMode.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(12, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.AutoSize = true;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Size = new System.Drawing.Size(69, 23);
            this.lblTime.TabIndex = 17;
            // 
            // lblFreeMemValue
            // 
            this.lblFreeMemValue.Location = new System.Drawing.Point(179, 14);
            this.lblFreeMemValue.Name = "lblFreeMemValue";
            this.lblFreeMemValue.ReadOnly = true;
            this.lblFreeMemValue.Size = new System.Drawing.Size(206, 23);
            this.lblFreeMemValue.TabIndex = 18;
            // 
            // lblOccupatedMemValue
            // 
            this.lblOccupatedMemValue.Location = new System.Drawing.Point(618, 14);
            this.lblOccupatedMemValue.Name = "lblOccupatedMemValue";
            this.lblOccupatedMemValue.ReadOnly = true;
            this.lblOccupatedMemValue.Size = new System.Drawing.Size(153, 23);
            this.lblOccupatedMemValue.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Receipt \r\nintensity\r\nprocesses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 63);
            this.label2.TabIndex = 21;
            this.label2.Text = "Minimum\r\nmeaning\r\ninterval\r\nCPU work";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 59);
            this.label3.TabIndex = 22;
            this.label3.Text = "Maximum\r\nmeaning\r\ninterval\r\nCPU work";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 46);
            this.label4.TabIndex = 23;
            this.label4.Text = "The size\r\noperational\r\nmemory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 62);
            this.label5.TabIndex = 24;
            this.label5.Text = "Minimum\r\nthe size\r\ntargeted\r\nspace\r\nprocess";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 62);
            this.label6.TabIndex = 25;
            this.label6.Text = "Maximum\r\nthe size\r\ntargeted\r\nspace\r\nprocess";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "CPU";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "External device";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Queue to the CPU";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Queue to external device";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "RAM";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 26);
            this.label12.TabIndex = 31;
            this.label12.Text = "Free memory size:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(394, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 26);
            this.label13.TabIndex = 32;
            this.label13.Text = "Size of memory occupied by processes:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(100, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Working mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudIntensity);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 106);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudBurstMin);
            this.groupBox2.Location = new System.Drawing.Point(139, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 106);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudBurstMax);
            this.groupBox3.Location = new System.Drawing.Point(266, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 106);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cbRamSize);
            this.groupBox4.Location = new System.Drawing.Point(397, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 106);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.nudAddrSpaceMin);
            this.groupBox5.Location = new System.Drawing.Point(526, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 106);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.nudAddrSpaceMax);
            this.groupBox6.Location = new System.Drawing.Point(658, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 106);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.lblOccupatedMemValue);
            this.groupBox7.Controls.Add(this.lblFreeMemValue);
            this.groupBox7.Location = new System.Drawing.Point(5, 356);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(780, 49);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.lblTime);
            this.groupBox8.Controls.Add(this.autoMode);
            this.groupBox8.Controls.Add(this.rbManual);
            this.groupBox8.Controls.Add(this.statistics);
            this.groupBox8.Controls.Add(this.end);
            this.groupBox8.Controls.Add(this.btnStart);
            this.groupBox8.Controls.Add(this.save);
            this.groupBox8.Location = new System.Drawing.Point(5, 411);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(786, 65);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.tbDevice);
            this.groupBox9.Location = new System.Drawing.Point(394, 112);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(386, 50);
            this.groupBox9.TabIndex = 42;
            this.groupBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.tbCPU);
            this.groupBox10.Location = new System.Drawing.Point(9, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(385, 47);
            this.groupBox10.TabIndex = 43;
            this.groupBox10.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(384, 45);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(400, 210);
            this.groupBox13.TabIndex = 28;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "groupBox13";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.lbCPUQueue);
            this.groupBox11.Location = new System.Drawing.Point(6, 160);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(386, 193);
            this.groupBox11.TabIndex = 44;
            this.groupBox11.TabStop = false;
            // 
            // lbCPUQueue
            // 
            this.lbCPUQueue.ItemHeight = 15;
            this.lbCPUQueue.Location = new System.Drawing.Point(8, 25);
            this.lbCPUQueue.Name = "lbCPUQueue";
            this.lbCPUQueue.Size = new System.Drawing.Size(378, 154);
            this.lbCPUQueue.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.lbDeviceQueue);
            this.groupBox12.Location = new System.Drawing.Point(397, 165);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(397, 191);
            this.groupBox12.TabIndex = 45;
            this.groupBox12.TabStop = false;
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetailed";
            this.Text = "System Software: Coursework";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button workingCycle;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.RadioButton manualMode;
        private System.Windows.Forms.RadioButton autoMode;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private TextBox lblOccupatedMemValue;
        private TextBox lblFreeMemValue;
        private TextBox tbDevice;
        private TextBox tbCPU;
        private ListBox lbDeviceQueue;
        private ListBox lbCPUQueue;
        private NumericUpDown nudAddrSpaceMin;
        private NumericUpDown nudAddrSpaceMax;
        private NumericUpDown nudIntensity;
        private NumericUpDown nudBurstMin;
        private NumericUpDown nudBurstMax;
        private ComboBox cbRamSize;
        private RadioButton rbManual;
        private Button btnWork;
        private Button btnStart;
    }
}