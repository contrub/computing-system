using Queues;
using System.Diagnostics.Contracts;
using System.Linq;

enum ProcessStatus
{
    ready,
    runnning,
    waiting,
    terminated
}

class Process : IComparable
{
    public Process(long pId, long addrSpace)
    {
        id = pId;
        AddrSpace = addrSpace;
        name = "P" + pId;
        Status = ProcessStatus.ready;
    }

    public void IncreaseWorkTime()
    {
        if (workTime < BurstTime)
        {
            workTime++;
            return;
        }

        Status = rnd.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
    }

    public void ResetWorkTime()
    {
        workTime = 0;
    }

    [Pure]
    public override string ToString()
    {
        return "Proc" + id + " BurstTime" + " WorkTime:" + ResetWorkTime +
            " Status" + Status.ToString();
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
        {
            return 1;
        }

        Process otheProcess = obj as Process;

        if (otheProcess != null)
        {
            if (BurstTime < otheProcess.BurstTime)
            {
                return 1;
            }

            return BurstTime < otheProcess.BurstTime ? 1 : 0;
        }
        else
        {
            throw new ArgumentException("Object is not a Process");
        }
    }

    private Random rnd;

    private long id;

    private string name;

    public long BurstTime { get; set; }

    public ProcessStatus Status { get; set; }

    private long workTime;

    public long AddrSpace { get; private set; }
}

class Resource
{
    public void WorkingCycle()
    {
        if (activeProcess.Status == ProcessStatus.runnning)
        {
            activeProcess.IncreaseWorkTime();
        }
    }

    public bool IsFree()
    {
        return activeProcess.Status == ProcessStatus.waiting;
    }

    public void Clear()
    {
        activeProcess.Status = ProcessStatus.terminated;
    }

    private Process activeProcess;

    public Process ActiveProcess { get; set; }
}

class Memory
{
    public void Save(long size)
    {
        Size = size;
        occupiedSize = 0;
    }

    public void Clear()
    {
        occupiedSize = 0;
    }

    public long Size { get; private set; }

    private long occupiedSize;

    public long OccupiedSize { get; set; }

    private long FreeSize
    {
        get
        {
            return Size - occupiedSize;
        }
    }
}

class SystemClock
{
    public void WorkingCycle()
    {
        clock++;
    }

    public void Clear()
    {
        clock = 0;
    }

    private long clock;
    public long Clock
    {
        get
        {
            return clock;
        }
        private set
        {
            clock = value;
        }
    }
}

class CPUScheduler
{
    CPUScheduler(Resource resource, IQueueable<Process> queue)
    {
        resource = resource;
        queue = queue;
    }

    public IQueueable<Process> Session()
    {
        resource.ActiveProcess = queue.Item();

        return queue;
    }

    private Resource resource;
    private IQueueable<Process> queue;
}

class DeviceScheduler
{
    DeviceScheduler(Resource resource, IQueueable<Process> queue)
    {
        resource = resource;
        queue = queue;
    }

    public IQueueable<Process> Session()
    {
        resource.ActiveProcess = queue.Item();

        return queue;
    }

    private Resource resource;
    private IQueueable<Process> queue;
}

class MemoryMamager
{
    public void Save(long size)
    {
        memory.Save(size);
    }

    public Memory Allocate(Process process)
    {
        if (process.AddrSpace > memory.OccupiedSize)
        {
            return null;
        }

        memory.OccupiedSize += process.AddrSpace;

        return memory;
    }

    public Memory Free(Process process)
    {
        memory.OccupiedSize -= process.AddrSpace;

        return memory;
    }

    private Memory memory;
}

class Settings
{
    public double Intensity
    { get; set; }

    public int MinValueOfBurstTime
    { get; set; }

    public int MaxValueOfBurstTime
    { get; set; }

    public int MinValueOfAddrSpace
    { get; set; }

    public int MaxValueOfAddrSpace
    { get; set; }

    public int ValueOfRAMSize
    { get; set; }
}

class IdGenerator
{
    public IdGenerator Clear()
    {
        if (this != null)
        {
            id = 0;
        }

        return this;
    }

    private long id;
    public long Id
    {
        get
        {
            return id == long.MaxValue ? 0 : ++id;
        }
    }
}