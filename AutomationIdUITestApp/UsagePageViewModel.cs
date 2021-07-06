using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AutomationIdUITestApp
{
    public class UsagePageViewModel : INotifyPropertyChanged
    {
        string input = string.Empty;
        public string Input
        {
            get => input;
            set
            {
                if (input == value)
                    return;

                input = value;
                OnPropertyChanged(nameof(Input));
                OnPropertyChanged(nameof(DisplayInput));
            }
        }

        public string DisplayInput => $"Your name is: {Input}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string input)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(input));
        }
    }
}
