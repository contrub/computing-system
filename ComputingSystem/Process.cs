using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

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

        public int CompareTo(Process otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }

        public event EventHandler FreeingAResource;

        private void OnFreeingAResource()
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(this, null);
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
}