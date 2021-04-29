using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EXAM_2
{
    public class Timer : INotifyPropertyChanged
    {
        private int m_timer;

        public int TimerValue
        {
            get
            {
                return m_timer;
            }
            set
            {
                this.m_timer = value;
                OnPropertyChanged("TimerValue");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
