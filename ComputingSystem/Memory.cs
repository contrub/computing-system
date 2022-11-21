using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem
{

    class Memory
    {
        public void Save(long size)
        {
            Size = size;
            occupiedSize = 0;
            FreeSize = size;
        }

        public void Clear()
        {
            occupiedSize = 0;
            FreeSize = Size;
        }

        public long Size { get; private set; }

        private long occupiedSize;

        public long OccupiedSize 
        {
            get 
            { 
                return occupiedSize; 
            }
            set { 
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged();
            } 
        }

        public long FreeSize 
        { 
            get
            {
                return Size - occupiedSize;
            }
            private set { }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
