using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Queues;
using Structures;

namespace ComputingSystem
{
    class Model: INotifyPropertyChanged
    {
        public Model()
        {
            clock = new SystemClock();
            deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new Queues.PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            modelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler = new DeviceScheduler(device, deviceQueue);
            memoryManager = new MemoryManager();
            ram = new Memory();
        }

        public IQueueable<Process> ReadyQueue 
        { 
            get
            {
                return readyQueue;
            }
            set
            {
                readyQueue = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue 
        { 
            get
            {
                return deviceQueue;
            }
            set
            {
                deviceQueue = value;
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
            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    // Subscribe(proc);
                    readyQueue = readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        cpuScheduler.Session();
                    }
                }
            }
            cpu.WorkingCycle();
            device.WorkingCycle();
        }

        private void FreeingResourceEventHandler(object sender, EventArgs e)
        {
            Process? proc = sender as Process;

            if (proc?.Status == ProcessStatus.waiting)
            {
                device.Clear();
                proc.Status = ProcessStatus.ready;
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                         modelSettings.MaxValueOfBurstTime + 1);
                proc.ResetWorkTime();

                readyQueue = readyQueue.Put(proc);

                if (cpu.IsFree())
                {
                    readyQueue = cpuScheduler.Session();
                    // Subscribe(cpu.ActiveProcess);
                }

                if (deviceQueue.Count != 0)
                {
                    deviceQueue = deviceScheduler.Session();
                    // Subscribe(device.ActiveProcess);
                }
            }
            else
            {
                cpu.Clear();
                if (readyQueue.Count != 0)
                {
                    readyQueue = cpuScheduler.Session();
                }

                proc.Status = processRand.Next(0, 2) == 0 ? ProcessStatus.terminated :
                        ProcessStatus.waiting;
                if (proc.Status == ProcessStatus.terminated)
                {
                    memoryManager.Free(proc);
                    // Unsubscribe(proc);
                }
                else
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    deviceQueue = deviceQueue.Put(proc);
                    if (device.IsFree())
                    {
                        deviceQueue = deviceScheduler.Session();
                    }
                }
            }
        }

        public void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            readyQueue.Clear();
            deviceQueue.Clear();
        }

        private void Subscribe(Resource resource)
        {
            if (resource.ActiveProcess != null)
                resource.ActiveProcess.FreeingAResource += FreeingAResourceEventHandler;
        }

        private void Unsubscribe(Resource resource)
        {
            if (resource.ActiveProcess != null)
                resource.ActiveProcess.FreeingAResource -= FreeingAResourceEventHandler;
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process? resourceFreeingProcess = sender as Process;

            switch (resourceFreeingProcess?.Status)
            {
                case ProcessStatus.terminated:
                    Unsubscribe(Cpu);
                    Cpu.Clear();
                    memoryManager.Free(resourceFreeingProcess);
                    if (readyQueue.Count != 0)
                        PutProcessOnResource(Cpu);
                    break;
                case ProcessStatus.waiting:
                    Unsubscribe(Cpu);
                    Cpu.Clear();
                    if (readyQueue.Count != 0)
                        PutProcessOnResource(Cpu);
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime =
                        processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    DeviceQueue = DeviceQueue.Put(resourceFreeingProcess);
                    if (Device.IsFree())
                    {
                        PutProcessOnResource(Device);
                    }
                    break;
                case ProcessStatus.ready:
                    Unsubscribe(Device);
                    Device.Clear();
                    if (deviceQueue.Count != 0)
                        PutProcessOnResource(Device);
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime =
                        processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    ReadyQueue = readyQueue.Put(resourceFreeingProcess);
                    if (Cpu.IsFree())
                    {
                        PutProcessOnResource(Cpu);
                    }
                    break;
                default:
                    throw new Exception("Uknown process status");
            }
        }

        private void PutProcessOnResource(Resource resource)
        {
            if (resource == Cpu)
            {
                ReadyQueue = cpuScheduler.Session();
            }
            else
            {
                DeviceQueue = cpuScheduler.Session();
            }
            Subscribe(resource);
        }

        public Settings ModelSettings
        {
            get { return modelSettings; }
        }

        public Resource Device
        {
            get { return device; }
        }

        public Resource Cpu
        {
            get { return cpu; }
        }

        public Memory Ram
        { 
            get { return ram; }
        }

        public SystemClock Clock
        {
            get { return clock; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly SystemClock clock;
        private readonly Resource cpu;
        public readonly Resource device;
        private readonly Memory ram;
        private readonly IdGenerator idGen;
        private IQueueable<Process> deviceQueue;
        private IQueueable<Process> readyQueue;
        private readonly CPUScheduler cpuScheduler;
        private readonly DeviceScheduler deviceScheduler;
        private readonly MemoryManager memoryManager;
        private readonly Random processRand;
        private readonly Settings modelSettings;

    }
}
