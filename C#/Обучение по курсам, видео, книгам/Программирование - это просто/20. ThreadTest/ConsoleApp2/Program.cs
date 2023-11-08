using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Factory.StartNew((Func<bool>)Work);
            task.ContinueWith(t => Console.WriteLine("Задачв выполнена. Результат: {0}", task.Result));
            Console.WriteLine("Основной поток завершен");
            Console.ReadLine();

        }

        static bool Work()
        {
            Console.WriteLine("Выполнение задачи...");
            Thread.Sleep(3000);

            return true;
        }
    }
}
