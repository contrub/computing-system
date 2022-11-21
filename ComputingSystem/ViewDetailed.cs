using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;
using System.ComponentModel;
using System.Globalization;
using System.Diagnostics;

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
            MessageBox.Show("DataBind !!");
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));

            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));

            frm.LblFreeMemValue.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));

            frm.LblOccupatedMemValue.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

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

            Binding ramSizeBinding = new("SelectedItem", model.ModelSettings, "ValueOfRAMSize");
            ramSizeBinding.Parse += ObjectToInt;
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudRamSize.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }

        public override void DataUnbind()
        {
            frm.NudIntensity.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.NudRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }

        private readonly FrmDetailed frm;

        private void ObjectToInt(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(int))
            {
                return;
            }

            cevent.Value = int.Parse(cevent.Value.ToString(), NumberStyles.Integer);
        }

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
                UpdateListBox(model.DeviceQueue, frm.LbDeviceQueue);
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
