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

namespace WinForm
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            butStart.Click += ButStart_Click;
            butStop.Click += ButStop_Click;

            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }


        private void ButStop_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            butStart.Enabled = false;
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (i == 30)
                    throw new Exception("Что-то пошло не так");

                worker.ReportProgress(i);
                Thread.Sleep(50);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("Ошибка: {0}", e.Error.Message));
            }
            else
            {
                string message = e.Cancelled ? "Процесс отменен" : "Процесс завершен!";
                MessageBox.Show(message);
            }
            butStart.Enabled = true;
        }

    }
}
