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
using System.Windows.Threading;

namespace WPF_EXAM_2
{
    /// <summary>
    /// Interaction logic for UserControlCalc.xaml
    /// </summary>
    public partial class UserControlCalc : UserControl
    {
        private MainWIndowViewModel viewModel = new MainWIndowViewModel();
        int i = 30;
        DispatcherTimer timer = new DispatcherTimer();

        public UserControlCalc()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            StartGame();
        }

        void StartGame() {
            timer.Tick += TimerTick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Start();
        }
        void TimerTick(object sender, EventArgs e)

        {
            if (i > 0 && i > 15)
            {
                txtTimer.Text = i.ToString();
                i--;
            }
            else if (i > 0)
            {
                txtTimer.Text = i.ToString();
                txtTask1.Foreground = Brushes.Red;
                txtTask2.Foreground = Brushes.Red;
                txtTask3.Foreground = Brushes.Red;
                txtTask4.Foreground = Brushes.Red;
                i--;
            }
            else {
                txtTimer.Text = "0";
                myUserControl.Background = Brushes.Red;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CheckTheResult(viewModel.Btn1.NumberValue);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            CheckTheResult(viewModel.Btn3.NumberValue);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            CheckTheResult(viewModel.Btn4.NumberValue);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CheckTheResult(viewModel.Btn2.NumberValue);
        }

        public void CheckTheResult(int result) {
            timer.Stop();
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            if (viewModel.MyNumber1.NumberValue * viewModel.MyNumber2.NumberValue == result)
                myUserControl.Background = Brushes.LightGreen;
            else
                myUserControl.Background = Brushes.Red;
        }
    }
}
