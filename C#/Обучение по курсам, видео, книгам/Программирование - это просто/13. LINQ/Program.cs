using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod2();
            Console.ReadLine();
        }

        //static void FilterData()
        //{
        //    TestSet set = new TestSet();
        //    var filterSet = set.Where(s => s > 50);
        //    foreach (int item in filterSet)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static void SelectData()
        //{
        //    TestSet set = new TestSet();
        //    var resultSet = set.Select(s => "*" + s.ToString() + "*");
        //    foreach (string i in resultSet)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void GetOneElement()
        //{
        //    TestSet set = new TestSet();
        //    var result = set.First(s => s % 2 == 0);
        //    Console.WriteLine(result);
        //}
        //static void Aggregate()
        //{
        //    TestSet set = new TestSet();
        //    var result = set.Where(i => i <= 5)
        //        .Aggregate(0, (acc, i) => acc * i);
        //    Console.WriteLine(result);
        //}
        //static void OrderBy()
        //{
        //    TestSet set = new TestSet();
        //    var resultSet = set.Select(i => new
        //    {
        //        Number = i,
        //        IsEven = i % 2 == 0
        //    }).OrderBy(r => r.IsEven);
        //    foreach (var item in resultSet)
        //    {
        //        Console.WriteLine(item.Number);
        //    }
        //}
        //static void TestMethod()
        //{
        //    TestSet set = new TestSet();
        //    var resultSet = set.Where(i => i % 2 == 0)
        //        .Select(i => "*" + i.ToString() + "*")
        //        .Where(i => i.Length == 4);
        //    foreach (var item in resultSet)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        static void TestMethod2()
        {
            TestSet set = new TestSet();
            var resultSet = set.Where(i => i % 2 == 0);
            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
