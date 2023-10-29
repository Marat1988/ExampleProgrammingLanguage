using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class StoreCollection : ICollection<int>
    {

        private readonly string _filePath;


        public StoreCollection(string filePath)
        {
            _filePath = filePath;
        }

        private string[] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);
            string[] numbers = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                yield return Int32.Parse(number);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(int item)
        {
            string[] numbers = GetNumbers();
            if (numbers.Length == 0)
                File.WriteAllText(_filePath, item.ToString());
            else
                File.AppendAllText(_filePath, "," + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, "");
        }

        public bool Remove(int item)
        {
            string[] numbers = GetNumbers();
            string line = File.ReadAllText(_filePath);
            int symbolPosition = 0;
            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                {
                    if (numbers.Length == 1)
                    {
                        line = "";
                    }
                    else if (symbolPosition == 0)
                    {
                        line = line.Substring(symbolPosition + number.Length + 1);
                    }
                    else
                    {
                        line = line.Remove(symbolPosition - 1, number.Length + 1);
                    }
                    File.WriteAllText(_filePath, line);
                    return true;
                }
                symbolPosition += number.Length + 1;
            }
            return false;
        }

        public bool Contains(int item)
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                    return true;
            }
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                array[arrayIndex] = Int32.Parse(number);
                arrayIndex++;
            }
        }

        public int Count
        {
            get
            {
                string[] numbers = GetNumbers();
                return numbers.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }











    }
}
