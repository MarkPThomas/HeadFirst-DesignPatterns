using System;
using System.Collections;
using System.Collections.Generic;

// From: http://stackoverflow.com/questions/1273001/net-is-there-a-hasnext-method-for-an-ienumerator

namespace Menus.Lib
{
    public sealed class IteratorAdapter<T> : IEnumerator<T>
    {
        private readonly IIterator<T> iterator;

        private bool gotCurrent = false;
        private T current;

        public IteratorAdapter(IIterator<T> iterator)
        {
            this.iterator = iterator;
        }

        public T Current
        {
            get
            {
                if (!gotCurrent)
                {
                    throw new InvalidOperationException();
                }
                return current;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            gotCurrent = iterator.HasNext();
            if (gotCurrent)
            {
                current = iterator.Next();
            }
            return gotCurrent;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
            iterator.Dispose();
        }
    }
}
