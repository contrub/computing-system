using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComputingSystem
{

    class Memory : INotifyPropertyChanged
    {
        public void Save(long size)
        {
            Size = size;
            OccupiedSize = 0;
        }

        public void Clear()
        {
            OccupiedSize = 0;
            Size = 0;
        }

        public long Size { get; private set; }

        private long occupiedSize;

        public long OccupiedSize 
        {
            get => occupiedSize; 
            set { 
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged();
            } 
        }

        public long FreeSize 
        { 
            get => Size - occupiedSize;
            private set { }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
