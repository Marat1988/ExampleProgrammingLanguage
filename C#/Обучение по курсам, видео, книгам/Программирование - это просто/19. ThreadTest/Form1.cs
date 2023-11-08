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
        private Object _context;
        public Form1()
        {
            InitializeComponent();

            butStart.Click += ButStart_Click;
            butStop.Click += ButStop_Click;
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = SynchronizationContext.Current;
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            _worker = new Worker();
            _worker.ProcessChanged += worker_ProcessChanged;
            _worker.WorkCompleted += _worker_WorkCompleted;

            butStart.Enabled = false;

            System.Threading.Thread thread = new System.Threading.Thread(_worker.Work);
            thread.Start(_context);
        }
        private void ButStop_Click(object sender, EventArgs e)
        {
            _worker?.Cancel();
        }

        private void _worker_WorkCompleted(bool cancelled)
        {
            string message = cancelled ? "Процесс отменен" : "Процесс завершен!";
            MessageBox.Show(message);
            butStart.Enabled = true;
        }
        private void worker_ProcessChanged(int progress)
        {
            progressBar1.Value = progress;
        }
    }
}
