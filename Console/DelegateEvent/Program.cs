using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateEvent.Student;

namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();
            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            string testString = "LAMP";
            Console.WriteLine("Общее количество символов: {0}", TestDelegate(d1, testString));
            Console.WriteLine("Количество символов A: {0}", TestDelegate(d2, testString));

            Student student = new Student();
            student.Moving += Student_Moving;
            student.Move(7);
            Console.ReadLine();
        }

        private static void Student_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
