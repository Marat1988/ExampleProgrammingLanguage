using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class WhereHelperEnumerator<T> : IEnumerator<T>
    {

        private readonly IEnumerator<T> _sourceEnumerator;
        private readonly Func<T, bool> _predicate;

        public WhereHelperEnumerator(IEnumerator<T> sourceEnumerator, Func<T, bool> predicate)
        {
            _sourceEnumerator = sourceEnumerator;
            _predicate = predicate;
        }

        public bool MoveNext()
        {
            bool isValid = false;
            while (_sourceEnumerator.MoveNext())
            {
                T current = _sourceEnumerator.Current;
                isValid = _predicate(current);
                if (isValid) break;
            }
            return isValid;
        }
        public void Reset()
        {
            _sourceEnumerator.Reset();
        }

        public T Current
        {
            get
            {
                return _sourceEnumerator.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _sourceEnumerator.Dispose();
        }
    }
}
