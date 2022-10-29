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
}