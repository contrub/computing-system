using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem
{
    class Statistics : INotifyPropertyChanged
    {
        public Statistics(SystemClock clock)
        {
            commonTime = clock;
            Subscribe();
        }
        public void Clear()
        {
            ArrivalProcessesCount = 0;
            CpuFreeTime = 0;
            CpuUtilization = 0;
        }
        public void IncCPUFreeTime()
        {
            CpuFreeTime++;
        }
        public void IncArrivalProcCount()
        {
            ArrivalProcessesCount++;
        }
        public long ArrivalProcessesCount { get; private set; }
        public long CpuFreeTime { get; private set; }
        public double CpuUtilization
        {
            get { return cpuUtilization; }
            private set
            {
                cpuUtilization = value;
                OnPropertyChanged();
            }
        }
        // подписчик
        private void Subscribe()
        {
            commonTime.PropertyChanged += PropertyChangedHandler;
        }
        private void Unsubscribe()
        {
            commonTime.PropertyChanged -= PropertyChangedHandler;
        }

        public long TerminatedProcessesCount { get; private set; }
        public double Throughput
        {
            get
            {
                return throughput;
            }
            private set
            {
                throughput = value;
                OnPropertyChanged();
            }
        }
        public void IncTerminatedProcCount()
        {
            TerminatedProcessesCount++;
        }

        private SystemClock commonTime;
        private double cpuUtilization;
        private double throughput;

        // издатель
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Clock")
            {
                CpuUtilization = ArrivalProcessesCount == 0 ? 0 : (commonTime.Clock - CpuFreeTime) / (double)commonTime.Clock;
                Throughput = (double)TerminatedProcessesCount / commonTime.Clock;
            }
        }
    }
}
