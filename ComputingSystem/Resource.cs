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
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            activeProcess.Status = ProcessStatus.terminated;
        }

        private Process activeProcess;

        public Process ActiveProcess { get; set; }
    }
}