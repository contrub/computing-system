using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}