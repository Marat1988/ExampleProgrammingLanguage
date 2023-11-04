using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butOK.Click += delegate { MessageBox.Show("Нажата клашива ОК"); };

            Func<int, int, int> func = (x, y) => x - y;
            Func<int, Func<int, int, int>, int> func2 = (k, f) => f(2, 3) * k;
            int result = func2(5, func);

            Func<int, int> fc = null;
            fc = i =>
            {
                MessageBox.Show(i.ToString());
                return i == 0 ? 0 : fc(--i);
            };
            fc(10);

            Action action = null;
            for (int cycleCounter = 1; cycleCounter <= 4; cycleCounter++)
            {
                int buffer = cycleCounter;
                action += () => MessageBox.Show(buffer.ToString());
            }
            action();



            MessageBox.Show(result.ToString());


        }
    }
}
