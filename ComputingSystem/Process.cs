using System.Diagnostics.Contracts;

namespace ComputingSystem
{
    enum ProcessStatus
    {
        ready,
        runnning,
        waiting,
        terminated,
        running
    }

    class Process : IComparable<Process>
    {
        public Process(long pId, long addrSpace)
        {
            id = pId;
            AddrSpace = addrSpace;
            name = "P" + pId.ToString();
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            workTime++;

            if (workTime != BurstTime) return;

            if (Status is not ProcessStatus.running)
            {
                Status = ProcessStatus.ready;
                OnFreeingAResource(device);
                return;
            }

            Status = rnd.Next(0, 2) != 0 ? ProcessStatus.waiting : ProcessStatus.terminated;
            device.DeviceNumber = rnd.Next(1, 4);
            OnFreeingAResource(device);
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }

        [Pure]
        public override string ToString()
        {
            return "Proc" + id + "; BurstTime: " + BurstTime + "; WorkTime: " + workTime.ToString() +
                "; Status: " + Status.ToString();
        }

        public int CompareTo (Process? otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }

        public event EventHandler FreeingAResource;

        private void OnFreeingAResource(ResourceEventArgs e)
        {
            FreeingAResource?.Invoke(this, e);
        }


        private readonly Random rnd = new();

        private readonly long id;

        private readonly string name;

        public long BurstTime { get; set; }

        public ProcessStatus Status { get; set; }

        private long workTime;

        public long AddrSpace { get; private set; }

        readonly ResourceEventArgs device = new();
    }
}