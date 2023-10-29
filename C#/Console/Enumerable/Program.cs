using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Progression progression = new Progression(100);
            foreach (int i in progression)
            {
                Console.WriteLine(i);
            }*/

            /*StoreCollection collection = new StoreCollection(@"C:\test\test.txt");
            foreach (int i in collection)
            {
                Console.WriteLine(i);
            }*/

            /*List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(5);
            lst.Add(6);
            Console.WriteLine(lst[2]);*/

            /*Dictionary<int, Person> persons = new Dictionary<int, Person>();

            Person person1 = new Person() { Id = 1, Name = "Петр" };
            Person person2 = new Person() { Id = 2, Name = "Василий" };

            persons.Add(person1.Id, person1);
            persons.Add(person2.Id, person2);

            Person searchPerson;
            bool isExist = persons.TryGetValue(2, out searchPerson);

            if (isExist)
                Console.WriteLine(searchPerson.Name);*/

            int[] arr = new int[5];
            IList<int> lst = arr;
            lst.Add(100);

            Console.ReadLine();
        }
    }
}
