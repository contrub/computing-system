using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem
{
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
}