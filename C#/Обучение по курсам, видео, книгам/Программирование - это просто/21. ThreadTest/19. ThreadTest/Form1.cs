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
        private CancellationTokenSource _tokenSource;
        public Form1()
        {
            InitializeComponent();

            butStart.Click += ButStart_Click;
            butStop.Click += ButStop_Click;
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        }

        private async void ButStart_Click(object sender, EventArgs e)
        {
            _worker = new Worker();
            _worker.ProcessChanged += worker_ProcessChanged;

            butStart.Enabled = false;

            _tokenSource = new CancellationTokenSource();
            CancellationToken token = _tokenSource.Token;

            Task<bool> task = null;
            bool isError = false;

            string message = "";

            try
            {
                task = Task<bool>.Factory.StartNew(() => _worker.Work(token), token);
                await task;
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                isError = true;
                message = string.Format("Произошла ошибка: {0}", ex.Message);
            }

            if (!isError)
                message = task.IsCanceled ? "Процесс отменет" : "Процесс завершен";

            MessageBox.Show(message);
            butStart.Enabled = true;
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }


        private void worker_ProcessChanged(int progress)
        {
            this.InvokeEx(() => { progressBar1.Value = progress; });
        }
    }
}
