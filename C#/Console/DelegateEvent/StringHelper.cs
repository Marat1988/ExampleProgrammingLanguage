using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate int CountDelegate(string message);
    public class StringHelper
    {
        public int GetCount(string inputString) => inputString.Length;
        public int GetCountSymbolA(string inputString) => inputString.Count(c => c == 'A');
        public int GetCountSymbol(string inputString, char symbol) => inputString.Count(c => c == symbol);

    }
}
