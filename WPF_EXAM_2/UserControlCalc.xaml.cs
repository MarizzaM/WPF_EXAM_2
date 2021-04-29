using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_EXAM_2
{
    /// <summary>
    /// Interaction logic for UserControlCalc.xaml
    /// </summary>
    public partial class UserControlCalc : UserControl
    {
        private MainWIndowViewModel viewModel = new MainWIndowViewModel();
        public UserControlCalc()
        {
            InitializeComponent();
            this.DataContext = viewModel;

            int i = 30;
            bool flag = true;

            Task.Run(() =>
            {
                for (i = 30; i >= 0; i--)
                {
                    Action uiwork = () => {
                        viewModel.MyTimer.TimerValue = i;
                    };
                    SafeInvoke(uiwork);
                    Thread.Sleep(1000);
                }
            });

            if (i == 0) {
                btn1.IsEnabled = false;
            }
        }
        private void SafeInvoke(Action work)
        {
            if (Dispatcher.CheckAccess())
            {
                work.Invoke();
                return;
            }
            this.Dispatcher.BeginInvoke(work);
        }
    }
}
