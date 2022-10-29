using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem
{
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
}