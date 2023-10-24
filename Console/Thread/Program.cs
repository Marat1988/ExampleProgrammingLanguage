using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace ThreadTets
{
    class Program
    {
        static int x = 0;
        static object locker = new object();
        static Mutex mutexObj = new Mutex();
        static void Main(string[] args)
        {
            Test3();
        }

        #region 81
        /*private static void threadTest()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine($"Имя потока: {t.Name}");
            t.Name = "Метод main";
            Console.WriteLine($"Имя потока: {t.Name}");

            Console.WriteLine($"Запушен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

            //получаем домен приложения
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");

            Console.ReadLine();
        }
        private static void createThread()
        {
            Counter c = new Counter();
            c.x = 5;
            c.y = 6;
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(c);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            for (int i = 1; i < 9; i++)
            {
                Counter c = (Counter)obj;
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * c.x * c.y);
            }
        }*/
        #endregion
        #region 82
        /*public static void LockThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }
            Console.ReadLine();
        }
        private static void Count()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }*/
        #endregion
        #region 83
        /*public static void LockThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }
            Console.ReadLine();
        }
        private static void Count()
        {
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }

            }
            finally
            {
                if (acquiredLock) Monitor.Exit(locker);
            }
        }*/
        #endregion
        #region 84
        /*public static void LockThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }
            Console.ReadLine();
        }
        private static void Count()
        {
            mutexObj.WaitOne();
            x = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
            mutexObj.ReleaseMutex();

        }*/
        #endregion
        #region 85
        /*public static void LockThread()
        {
            for (int i = 0; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }
            Console.ReadLine();
        }

        class Reader
        {
            static Semaphore sem = new Semaphore(3, 3);
            Thread myThread;
            int count = 3;

            public Reader(int i)
            {
                myThread = new Thread(Read);
                myThread.Name = $"Читатель {i.ToString()}";
                myThread.Start();
            }
            public void Read()
            {
                while (count > 0)
                {
                    sem.WaitOne();
                    Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");
                    Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");
                    sem.Release();

                    count--;
                    Thread.Sleep(1000);
                }
            }
        }*/
        #endregion
        #region 86
        /*public static void timer()
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, num, 0, 2000);
            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 0; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }*/
        #endregion
        #region 88
        /*class A1
        {
            public int A { get; set; }
        }*/
        #endregion
        #region 89
        /*public static void Test()
        {
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }

        public static BigInteger Factorial(BigInteger a)
        {
            return (a == 1) ? 1 : (a * Factorial(a - 1));
        }*/
        #endregion
        #region 90
        /*public static void Test()
        {
            Func<string, string> someFunc = delegate (string someVariable)
            {
                return "Hello World!";
            };
            string str = someFunc("This is a demo");
            Console.WriteLine(str);
            Console.ReadLine();
        }

        public static void Test2()
        {
            int x = 10;
            Action a = delegate
            {
                Console.WriteLine($"The value of x is {x}");
            };
            x = 100;
            a();
            Console.ReadLine();
        }

        public static void Test3()
        {
            var actions = new List<Action>();
            foreach (var i in Enumerable.Range(1, 3))
            {
                actions.Add(() => Console.WriteLine(i));
            }
            foreach (var action in actions)
            {
                action();
            }
            Console.ReadLine();
        }*/
        #endregion
        #region 91
        /*public static void Test()
        {
            Task task1 = new Task(() => Console.WriteLine("Hello Task1!"));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task2!"));
            Task task3 = Task.Run(() => Console.WriteLine("Hello Task3!"));
            Console.ReadLine();
        }
        public static void Test2()
        {
            Task task = new Task(Display);
            task.Start();
            task.Wait();
            Console.WriteLine("Заверешние метода Main");
            Console.ReadLine();
        }

        private static void Display()
        {
            Console.WriteLine("Начало работы метода Display");
            Console.WriteLine("Завершение работы метода Display");
        }*/
        #endregion
        #region 92
        /*public static void Test()
        {
            var outer = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished.");
                }, TaskCreationOptions.AttachedToParent);
            });
            outer.Wait();
            Console.WriteLine("End of Main");
            Console.ReadLine();

        }
        public static void Test2()
        {
            Task[] tasks1 = new Task[3]
            {
                new Task(()=>Console.WriteLine("First Task")),
                new Task(()=>Console.WriteLine("Second Task")),
                new Task(()=>Console.WriteLine("Third Task"))
            };
            foreach (var t in tasks1)
            {
                t.Start();
            }
            Console.ReadLine();
        }
        public static void Test3()
        {
            Task[] tasks2 = new Task[3];
            int j = 1;
            for (int i = 0; i < tasks2.Length; i++)
            {
                tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));
            }
            Console.ReadLine();
        }
        public static void Test4()
        {
            Task[] tasks1 = new Task[3]
            {
                new Task(()=>Console.WriteLine("First Task")),
                new Task(()=>Console.WriteLine("Second Task")),
                new Task(()=>Console.WriteLine("Third Task"))
            };
            foreach (var t in tasks1)
                t.Start();
            Task.WaitAll(tasks1);

            Task[] tasks2 = new Task[3];
            int j = 1;
            for (int i = 0; i < tasks2.Length; i++)
            {
                tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));
            }

            Console.WriteLine("Завершение работы метода Main");
            Console.ReadLine();


        }
        public static void Test5()
        {
            Task<int> task1 = new Task<int>(() => Factorial(5));
            task1.Start();
            Console.WriteLine($"Факториал числа 5 равен {task1.Result}");

            Task<Book> task2 = new Task<Book>(() =>
            {
                return new Book { Title = "Война и мир", Author = "Л. Толстой" };
            });
            task2.Start();
            Book b = task2.Result;
            Console.WriteLine($"Название книги: {b.Title}, автор: {b.Author}");
            Console.ReadLine();
        }
        public static int Factorial(int number) => (number == 1) ? 1 : (number * Factorial(number - 1));*/
        #endregion
        #region 93
        /*public static void Test()
        {
            Parallel.Invoke(Display,
                () =>
                {
                    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                    Thread.Sleep(3000);
                },
                () => Factorial(5)
                );
            Console.ReadLine();
        }

        public static void Test2()
        {
            Parallel.For(1, 10, Factorial);
            Console.ReadLine();
        }

        public static void Test3()
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int> { 1, 3, 5, 8 },
                Factorial2);
            if (!result.IsCompleted)
                Console.WriteLine($"Выполнение цикла завернено на итерации {result.LowestBreakIteration}");
            Console.ReadLine();
        }

        public static void Display()
        {
            Console.WriteLine($"Выполяется задача {Task.CurrentId}");
            Thread.Sleep(3000);
        }

        static void Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Выполяется задача {Task.CurrentId}");
            Console.WriteLine($"Factorial number {x} = {result}");
            Thread.Sleep(3000);
        }
        static void Factorial2(int x, ParallelLoopState pls)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
                if (i == 5)
                {
                    pls.Break();
                }
            }
            Console.WriteLine($"Выполяется задача {Task.CurrentId}");
            Console.WriteLine($"Factorial number {x} = {result}");
        }*/
        #endregion
        #region 94
        public static void Test()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            int number = 6;
            Task task1 = new Task(() =>
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    result *= i;
                    Console.WriteLine($"Факториал числа {i} равен {result}");
                    Thread.Sleep(5000);
                }
            });
            task1.Start();
            Console.WriteLine("Введите Y для отмены оперпции или другой символ для ее продолжения");
            string s = Console.ReadLine();
            if (s == "Y")
                cancellationTokenSource.Cancel();
            Console.Read();
        }
        public static void Test2()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task1 = new Task(() => Factorial(5, token));
            task1.Start();
            Console.WriteLine("Введите Y для отмены операции или любой другой символ для ее продолжения:");
            string s = Console.ReadLine();
            if (s == "Y")
            {
                cancellationTokenSource.Cancel();
            }
            Console.ReadLine();
        }
        public static void Test3()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            new Task(() =>
            {
                Thread.Sleep(400);
                cancellationTokenSource.Cancel();
            }).Start();
            try
            {
                Parallel.ForEach(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 },
                    new ParallelOptions { CancellationToken = token }, Factorial2);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("Операция прервана");
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }
            Console.ReadLine();
        }
        static void Factorial(int x, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                result *= i;
                Console.WriteLine($"Factorial number {i} = {result}");
                Thread.Sleep(5000);
            }
        }
        static void Factorial2(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial number {x} = {result}");
            Thread.Sleep(5000);
        }
        #endregion

    }

}

public class Counter
{
    public int x;
    public int y;
}

