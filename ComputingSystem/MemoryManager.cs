namespace ComputingSystem
{
    class MemoryManager
    {
        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process proc)
        {
            if (memory.FreeSize >= proc.AddrSpace)
            {
                memory.OccupiedSize += proc.AddrSpace;
                return memory;
            }

            return null;
        }

        public Memory Free(Process proc)
        {
            memory.OccupiedSize -= proc.AddrSpace;

            return memory;
        }

        private Memory memory;
    }
}