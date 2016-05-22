using System.Collections;
using System.Collections.Generic;

// From: http://stackoverflow.com/questions/1273001/net-is-there-a-hasnext-method-for-an-ienumerator

namespace Menus.Lib
{
    public sealed class IterableAdapter<T> : IEnumerable<T>
    {
        private readonly IIterable<T> iterable;

        public IterableAdapter(IIterable<T> iterable)
        {
            this.iterable = iterable;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new IteratorAdapter<T>(iterable.Iterator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
