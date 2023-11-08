using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.ThreadTest
{
    public partial class Form1 : Form
    {
        private Worker _worker;
        private TaskScheduler _scheduler;
        public Form1()
        {
            InitializeComponent();

            butStart.Click += ButStart_Click;
            butStop.Click += ButStop_Click;
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Action action = () =>
            {
                while (true)
                {
                    Invoke((Action)(() => lblTime.Text = DateTime.Now.ToLongTimeString()));
                    Thread.Sleep(1000);
                }
            };
            Task task = new Task(action);
            task.Start();
            //Task task = Task.Factory.StartNew(action);
        }

        private async void ButStart_Click(object sender, EventArgs e)
        {
            _worker = new Worker();
            _worker.ProcessChanged += worker_ProcessChanged;

            butStart.Enabled = false;

            var cancelled = await Task<bool>.Factory.StartNew(_worker.Work);
            //task.ContinueWith((t, o) => _worker_WorkCompleted(t.Result), null, _scheduler);
            string message = cancelled ? "Процесс отменет" : "Процесс завершен";
            MessageBox.Show(message);
            butStart.Enabled = true;
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            _worker?.Cancel();
        }

        private void _worker_WorkCompleted(bool cancelled)
        {

        }

        private void worker_ProcessChanged(int progress)
        {
            this.InvokeEx(() => { progressBar1.Value = progress; });
        }
    }
}
