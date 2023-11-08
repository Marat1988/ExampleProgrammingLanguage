using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19.ThreadTest
{
    public class Worker
    {
        private bool _cancelled = false;

        public void Cancel()
        {
            _cancelled = true;
        }

        public bool Work()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (_cancelled)
                    break;

                Thread.Sleep(50);

                OnProgressChanged(i);
            }
            return _cancelled;
        }

        public void OnProgressChanged(int i)
        {
            if (ProcessChanged != null)
            {
                ProcessChanged((int)i);
            }
        }

 

        public event Action<int> ProcessChanged;
        public event Action<bool> WorkCompleted;
    }
}
