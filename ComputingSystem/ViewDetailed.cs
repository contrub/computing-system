using Queues;
using System.ComponentModel;

namespace ComputingSystem
{
    class ViewDetailed: View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm)
            : base(model, controller)
        {
            this.frm = frm;
        }

        public override void DataBind()
        {
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));
            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));
            frm.TbDevice1.DataBindings.Add(new Binding("Text", model.Device1, "ActiveProcess"));
            frm.TbDevice2.DataBindings.Add(new Binding("Text", model.Device2, "ActiveProcess"));
            frm.LblFreeMemValue.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));
            frm.LblOccupiedMemValue.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

            Binding intensityBinding = new("Value", model.ModelSettings, "Intensity")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.NudIntensity.DataBindings.Add(intensityBinding);

            Binding burstMinBinding = new("Value", model.ModelSettings, "MinValueOfBurstTime")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.NudBurstMin.DataBindings.Add(burstMinBinding);

            Binding burstMaxBinding = new("Value", model.ModelSettings, "MaxValueOfBurstTime")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.NudBurstMax.DataBindings.Add(burstMaxBinding);


            Binding addrSpaceMinBinding = new("Value", model.ModelSettings, "MinValueOfAddrSpace")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.NudAddrSpaceMin.DataBindings.Add(addrSpaceMinBinding);

            Binding addrSpaceMaxBinding = new("Value", model.ModelSettings, "MaxValueOfAddrSpace")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.NudAddrSpaceMax.DataBindings.Add(addrSpaceMaxBinding);

            Binding ramSizeBinding = new("SelectedItem", model.ModelSettings, "ValueOfRAMSize")
            {
                ControlUpdateMode = ControlUpdateMode.Never
            };
            frm.CbRamSize.DataBindings.Add(ramSizeBinding);

            Binding CpuUtilBinding = new Binding("Text", model.statistics, "CpuUtilization", true, DataSourceUpdateMode.Never, null, "#0.##%");
            frm.TbCpuUtil.DataBindings.Add(CpuUtilBinding);

            Binding CpuProductivityBinding = new Binding("Text", model.statistics, "Throughput", true, DataSourceUpdateMode.Never, null, "#0.##%");
            frm.TbProductivity.DataBindings.Add(CpuProductivityBinding);

            Subscribe();
        }

        public override void DataUnbind()
        {
            frm.NudIntensity.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }

        private FrmDetailed frm;

        private void Subscribe()
        {
            model.PropertyChanged += PropertyChangedHandler;
        }

        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                UpdateListBox(model.ReadyQueue, frm.LbCPUQueue);
            }
            else
            {
                UpdateListBox(model.DeviceQueue1, frm.LbDeviceQueue1);
                UpdateListBox(model.DeviceQueue2, frm.LbDeviceQueue2);
                UpdateListBox(model.DeviceQueue3, frm.LbDeviceQueue3);
            }
        }

        private static void UpdateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
    }
}
