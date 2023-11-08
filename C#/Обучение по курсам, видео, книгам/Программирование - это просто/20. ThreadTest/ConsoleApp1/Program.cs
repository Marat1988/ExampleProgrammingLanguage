using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Work, i);
                Thread.Sleep(200);
            }
            Console.ReadLine();
        }

        private static void Work(object i)
        {
            Console.WriteLine("Идентификатор потока: {0}, параметр: {1}", Thread.CurrentThread.ManagedThreadId, i);
        }
    }
}
