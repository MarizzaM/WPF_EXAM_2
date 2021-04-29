using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EXAM_2
{
    class MainWIndowViewModel
    {
        public Timer MyTimer { get; set; }
        public DelegateCommand MyDelegate { get; set; }

        public MainWIndowViewModel()
        {
            MyTimer = new Timer() { TimerValue = 30 };

        }
    }
}
