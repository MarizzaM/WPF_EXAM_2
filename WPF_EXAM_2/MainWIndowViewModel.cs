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
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public Number MyNumber1 { get; set; }
        public Number MyNumber2 { get; set; }
        public Number Btn1 { get; set; }
        public Number Btn2 { get; set; }
        public Number Btn3 { get; set; }
        public Number Btn4 { get; set; }

        public DelegateCommand MyDelegate { get; set; }

        static Random random = new Random();
        public MainWIndowViewModel()
        {
            MyNumber1 = new Number() { NumberValue = random.Next(11,49)};
            MyNumber2 = new Number() { NumberValue = random.Next(11, 49) };

            List<int> answers = new List<int>();
            answers.Add(MyNumber1.NumberValue * MyNumber2.NumberValue);
            answers.Add(random.Next(121, 2401));
            answers.Add(random.Next(121, 2401));
            answers.Add(random.Next(121, 2401));

            int item = answers.ElementAt(random.Next(3));
            Btn1 = new Number() { NumberValue = item };
            answers.Remove(item);

            item = answers.ElementAt(random.Next(2));
            Btn2 = new Number() { NumberValue = item };
            answers.Remove(item);

            item = answers.ElementAt(random.Next(1));
            Btn3 = new Number() { NumberValue = item };
            answers.Remove(item);

            Btn4 = new Number() { NumberValue = answers.ElementAt(random.Next(0)) };
            answers.Remove(0);
        }
    }
}
