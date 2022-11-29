namespace ComputingSystem
{
    public partial class FrmDetailed : Form
    {
        public FrmDetailed()
        {
            InitializeComponent();
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
            btnSessionEnd.Enabled = false;
            btnStart.Enabled = true;
            btnWork.Enabled = false;
        }

        private ViewDetailed viewDetailed { get; set; }
        public Label LblTime => lblTime;
        public ListBox LbCPUQueue => lbCPUQueue;
        public ListBox LbDeviceQueue1 => lbDeviceQueue1;
        public ListBox LbDeviceQueue2 => lbDeviceQueue2;
        public ListBox LbDeviceQueue3 => lbDeviceQueue1;
        public TextBox TbCPU => tbCPU;
        public TextBox TbDevice1 => tbDevice1;
        public TextBox TbDevice2 => tbDevice2;

        public TextBox TbCpuUtil => tbCpuUtil;
        public TextBox TbProductivity => tbProductivity;

        public Label LblFreeMemValue => lblFreeMemValue;
        public Label LblOccupiedMemValue => lblOccupiedMemValue;
        public ComboBox CbRamSize => cbRamSize;
        public NumericUpDown NudIntensity => nudIntensity;
        public NumericUpDown NudBurstMin => nudBurstMin;
        public NumericUpDown NudBurstMax => nudBurstMax;
        public NumericUpDown NudAddrSpaceMin => nudAddrSpaceMin;
        public NumericUpDown NudAddrSpaceMax => nudAddrSpaceMax;
        public TableLayoutPanel TlPanelSettings => tlPanelSettings;

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
            UpdateSettings();
        }

        private void sessionPreparation()
        {
            btnStart.Enabled = false;
            btnSessionEnd.Enabled = true;
            //btnWork.Enabled = true;
            btnWork.Enabled = rbManual.Checked;
            if (rbManual.Checked == false)
            {
                timer.Start();
            }
            TlPanelSettings.Enabled = false;
        }

        private void endOfSession()
        {
            btnSessionEnd.Enabled = false;
            btnStart.Enabled = true;
            btnWork.Enabled = false;
            TlPanelSettings.Enabled = true;
            if (rbAuto.Checked == true)
            {
                timer.Stop();
            }
        }

        private void UpdateSettings()
        {
            nudIntensity.Value = 0.5m;
            nudBurstMin.Value = nudBurstMin.Minimum;
            nudBurstMax.Value = nudBurstMax.Minimum;
            nudAddrSpaceMin.Value = nudAddrSpaceMin.Minimum;
            nudAddrSpaceMax.Value = nudAddrSpaceMax.Minimum;
            cbRamSize.SelectedItem = cbRamSize.Items[0];
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbManual.Checked && btnSessionEnd.Enabled)
            {
                timer.Start();
                btnWork.Enabled = false;
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked && btnSessionEnd.Enabled)
            {
                timer.Stop();
                btnWork.Enabled = true;
            }
        }
    }
}
