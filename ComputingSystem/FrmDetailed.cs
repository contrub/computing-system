namespace ComputingSystem
{
    public partial class FrmDetailed : Form
    {
        private readonly ViewDetailed viewDetailed;

        public FrmDetailed()
        {
            InitializeComponent();

            cbRamSize.SelectedItem = cbRamSize.Items[0];

            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }

        public Label LblTime => lblTime;
        public TextBox TbCPU => tbCPU;
        public TextBox TbDevice => tbDevice;
        public TextBox LblFreeMemValue => lblFreeMemValue;
        public TextBox LblOccupatedMemValue => lblOccupatedMemValue;
        public NumericUpDown NudIntensity => nudIntensity;
        public NumericUpDown NudBurstMin => nudBurstMin;
        public NumericUpDown NudBurstMax => nudBurstMax;
        public NumericUpDown NudAddrSpaceMin => nudAddrSpaceMin;
        public NumericUpDown NudAddrSpaceMax => nudAddrSpaceMax;
        public ComboBox CbRamSize => cbRamSize;
        public ListBox LbCPUQueue => lbCPUQueue;
        public ListBox LbDeviceQueue => lbDeviceQueue;

        private void btnStart_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void btnSessionEnd_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            endOfSession();
            updateSettings();
        }

        private void sessionPreparation()
        {
            btnStart.Enabled = false;
            // btnSessionEnd.Enabled = true;
            btnWork.Enabled = rbManual.Checked;
            // pnlSettings.Enabled = false;
        }

        private void endOfSession()
        {
            // btnSession.Enabled = false;
            // btnStart.Enabled = true;
            btnWork.Enabled = false;
            // pnlSettings.Enabled = true;
            LblTime.Text = "0";
        }

        private void updateSettings()
        {
            nudIntensity.Value = 0.5m;
            nudBurstMin.Value = nudBurstMin.Minimum;
            nudBurstMax.Value = NudBurstMax.Maximum;
            nudAddrSpaceMin.Value = nudAddrSpaceMin.Minimum;
            nudAddrSpaceMax.Value = nudAddrSpaceMax.Maximum;
            // nudRamSize.SelectedItem = nudRamSize.Items[0];
        }

        private void workingCycle_Click(object sender, EventArgs e)
        {
            Model model = new();
            model.ModelSettings.Intensity = 0.8;
            model.ModelSettings.MinValueOfAddrSpace = 100;
            model.ModelSettings.MaxValueOfAddrSpace = 300;
            model.ModelSettings.MinValueOfBurstTime = 3;
            model.ModelSettings.MaxValueOfBurstTime = 7;
            model.ModelSettings.ValueOfRAMSize = 32000;
            model.SaveSettings();

            for (int i = 0; i < 20; i++)
            {
                model.WorkingCycle();
                if (model.Cpu.ActiveProcess != null)
                {
                    MessageBox.Show("On cpu: " + model.Cpu.ActiveProcess.ToString());
                }
                if (model.ReadyQueue.Count != 0)
                {
                    MessageBox.Show("Первый в очереди готовых процессов: " + model.ReadyQueue.Item());
                }
                if (model.Device.ActiveProcess != null)
                {
                    MessageBox.Show("On device: " + model.Device.ActiveProcess.ToString());
                }
                if (model.DeviceQueue.Count != 0)
                {
                    MessageBox.Show("Первый в очереди к внешнему устройству: " + model.DeviceQueue.Item());
                }
            }
        }
    }
}