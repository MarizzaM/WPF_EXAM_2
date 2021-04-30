using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EXAM_2
{
    public class Number : INotifyPropertyChanged
    {
        private int m_number;

        public int NumberValue
        {
            get
            {
                return m_number;
            }
            set
            {
                this.m_number = value;
                OnPropertyChanged("NumberValue");
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
