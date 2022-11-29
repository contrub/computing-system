using System.ComponentModel;
using System.Runtime.CompilerServices;
using Queues;
using Structures;

namespace ComputingSystem
{
    class Model: INotifyPropertyChanged
    {
        public Model()
        {
            clock = new SystemClock();
            deviceQueue1 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue3 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new Queues.PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            modelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device1 = new Resource();
            device2 = new Resource();
            device3 = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler1 = new DeviceScheduler(device1, deviceQueue1);
            deviceScheduler2 = new DeviceScheduler(device2, deviceQueue2);
            deviceScheduler3 = new DeviceScheduler(device3, deviceQueue3);
            memoryManager = new MemoryManager();
            ram = new Memory();
            statistics = new Statistics(Clock);
        }

        public IQueueable<Process> ReadyQueue 
        { 
            get => readyQueue;
            set
            {
                readyQueue = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue1 
        { 
            get => deviceQueue1;
            set
            {
                deviceQueue1 = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue2
        {
            get => deviceQueue2;
            set
            {
                deviceQueue2 = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue3
        {
            get => deviceQueue3;
            set
            {
                deviceQueue3 = value;
                OnPropertyChanged();
            }
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
            memoryManager.Save(ram);
        }

        public void WorkingCycle()
        {
            clock.WorkingCycle();

            if (processRand.NextDouble() <= ModelSettings.Intensity)
            {
                Process proc = new(
                    idGen.Id,
                    processRand.Next(
                        modelSettings.MinValueOfAddrSpace, 
                        modelSettings.MaxValueOfAddrSpace + 1
                        )
                    );
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(
                        modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1
                        );
                    Subscribe(proc);
                    readyQueue = readyQueue.Put(proc);

                    if (cpu.IsFree())
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                }
            }

            cpu.WorkingCycle();
            device1.WorkingCycle();
            device2.WorkingCycle();
            device3.WorkingCycle();

            if (Cpu.IsFree())
            {
                statistics.IncCPUFreeTime();
            }

            statistics.IncArrivalProcCount();
        }

        public void Clear()
        {
            cpu.Clear();
            device1.Clear();
            device2.Clear();
            device3.Clear();
            ram.Clear();
            readyQueue = readyQueue.Clear();
            deviceQueue1 = deviceQueue1.Clear();
            deviceQueue2 = deviceQueue2.Clear();
            deviceQueue3 = deviceQueue3.Clear();
            clock.Clear();
            idGen.Clear();
            statistics.Clear();
        }

        private void Subscribe(Process proc)
        {
            if (proc != null)
                proc.FreeingAResource += FreeingResourceEventHandler;
        }

        private void Unsubscribe(Process proc)
        {
            if (proc != null)
                proc.FreeingAResource -= FreeingResourceEventHandler;
        }

        private void FreeingResourceEventHandler(object sender, EventArgs e)
        {
            Process proc = sender as Process;

            if (proc.Status == ProcessStatus.waiting) 
            {
                device1.Clear();
                device2.Clear();
                device3.Clear();

                proc.Status = ProcessStatus.ready;
                proc.BurstTime = processRand.Next(
                    ModelSettings.MinValueOfBurstTime, 
                    ModelSettings.MaxValueOfBurstTime + 1
                    );
                proc.ResetWorkTime();

                ReadyQueue = readyQueue.Put(proc);

                if (cpu.IsFree())
                {
                    ReadyQueue = cpuScheduler.Session();
                    Subscribe(Cpu.ActiveProcess);
                }

                if (deviceQueue1.Count != 0)
                {
                    DeviceQueue1 = deviceScheduler1.Session();
                    Subscribe(Device1.ActiveProcess);
                }
                else if (deviceQueue2.Count != 0)//
                {
                    DeviceQueue2 = deviceScheduler2.Session();
                    Subscribe(Device2.ActiveProcess);
                }
                else if (deviceQueue3.Count != 0)
                {
                    DeviceQueue3 = deviceScheduler3.Session();
                    Subscribe(Device3.ActiveProcess);
                }
            }
            else
            {
                cpu.Clear();
                if (readyQueue.Count != 0)
                {
                    ReadyQueue = cpuScheduler.Session();
                }

                proc.Status = processRand.Next(0, 2) == 0 
                    ? ProcessStatus.terminated 
                    : ProcessStatus.waiting;

                if (proc.Status == ProcessStatus.terminated)
                {
                    memoryManager.Free(proc);
                    Unsubscribe(proc);
                }
                else
                {
                    proc.BurstTime = processRand.Next(
                        ModelSettings.MinValueOfBurstTime, 
                        ModelSettings.MaxValueOfBurstTime + 1
                        );
                    proc.ResetWorkTime();
                    DeviceQueue1 = deviceQueue1.Put(proc);
                    DeviceQueue2 = deviceQueue2.Put(proc);
                    DeviceQueue3 = deviceQueue3.Put(proc);
                    if (device1.IsFree())
                    {
                        DeviceQueue1 = deviceScheduler1.Session();
                    }
                    else if (device2.IsFree())
                    {
                        DeviceQueue2 = deviceScheduler2.Session();
                    } else
                    {
                        DeviceQueue3 = deviceScheduler3.Session();
                    }
                }
            }
        }

        public Settings ModelSettings => modelSettings;
        public Resource Device1 => device1;
        public Resource Device2 => device2;
        public Resource Device3 => device3;
        public Resource Cpu => cpu;
        public Memory Ram => ram;
        public SystemClock Clock => clock;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public readonly SystemClock clock;
        private Resource cpu;
        private Resource device1;
        private Resource device2;
        private Resource device3;
        private Memory ram;
        private IdGenerator idGen;
        private IQueueable<Process> deviceQueue1;
        private IQueueable<Process> deviceQueue2;
        private IQueueable<Process> deviceQueue3;
        private IQueueable<Process> readyQueue;
        private CPUScheduler cpuScheduler;
        private DeviceScheduler deviceScheduler1;
        private DeviceScheduler deviceScheduler2;
        private DeviceScheduler deviceScheduler3;
        private MemoryManager memoryManager;
        private Random processRand;
        private Settings modelSettings;
        public readonly Statistics statistics;
    }
}
