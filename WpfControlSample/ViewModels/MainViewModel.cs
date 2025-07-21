using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlSample.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private bool _isOn;
        public event PropertyChangedEventHandler? PropertyChanged;

        public bool IsOn
        {
            get => _isOn;
            set
            {
                if (_isOn != value)
                {
                    _isOn = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsOn)));
                }
            }
        }
        public MainViewModel()
        {
            _isOn = false;
        }
    }
}
