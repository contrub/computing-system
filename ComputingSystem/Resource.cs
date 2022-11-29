using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComputingSystem
{
    class Resource: INotifyPropertyChanged
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
            activeProcess = null;
        }

        private Process activeProcess;

        public Process ActiveProcess 
        { 
            get => activeProcess;
            set
            {
                activeProcess = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}