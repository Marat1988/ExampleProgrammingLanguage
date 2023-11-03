using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position;
        private int _current;

        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }

        public void Dispose(){}

        public bool MoveNext()
        {
            if (_position > 0)
            {
                _current += 1;
            }
            if (_position < _itemCount)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = 0;
            _current = 1;
        }


        public int Current
        {
            get
            {
                return _current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

  



   
    }
}
