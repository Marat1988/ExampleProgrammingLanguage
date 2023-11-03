using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class Student
    {
        public delegate void ShowMessage(string message);
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                if (Moving != null)
                {
                    Moving(this, new MovingEventArgs(string.Format("Идет перемещение... Пройдено километров: {0}", i)));
                }

            }
        }

        //public Action<string> Moving { get; set; }
        public event EventHandler<MovingEventArgs> Moving;

        public int GetAge() => 17;
        public string Grow(int years) => null;
        public void SetInfo(string name, int age) { }
        public void SetSchool(int id, string number) { }
    }
}
