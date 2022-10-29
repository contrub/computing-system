using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace ComputingSystem
{
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
}