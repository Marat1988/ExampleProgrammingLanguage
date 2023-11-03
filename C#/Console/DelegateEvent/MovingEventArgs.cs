using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class MovingEventArgs: EventArgs
    {
        public string Message { get; private set; }
        public MovingEventArgs(string message)
        {
            Message = message;
        }
    }
}
