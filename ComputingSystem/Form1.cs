namespace ComputingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void workingCycle_Click(object sender, EventArgs e)
        {
            Model model = new Model();
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
                    //Console.WriteLine("On cpu: {0}", model.Cpu.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On cpu: " + model.Cpu.ActiveProcess.ToString());
                }
                if (model.ReadyQueue.Count != 0)
                {
                    //Console.WriteLine("Первый в очереди гоовых процессов: {0}", model.ReadyQueue.Item());
                    MessageBox.Show("Первый в очереди готовых процессов: " + model.ReadyQueue.Item());
                }
                if (model.Device.ActiveProcess != null)
                {
                    //Console.WriteLine("On device: {0}", model.Device.ActiveProcess);
                    // или для Windows Forms
                    MessageBox.Show("On device: " + model.Device.ActiveProcess.ToString());
                }
                if (model.DeviceQueue.Count != 0)
                {
                    //Console.WriteLine("Первый в очереди к внешнему устройству: {0}", model.DeviceQueue.Item());
                    MessageBox.Show("Первый в очереди к внешнему устройству: " + model.DeviceQueue.Item());
                }
            }


        }
    }
}