using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem
{

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

        public long FreeSize
        {
            get;
            private set;
        }
    }

}
