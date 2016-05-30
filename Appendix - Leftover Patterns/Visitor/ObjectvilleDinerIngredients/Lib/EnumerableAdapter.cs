using System.Collections.Generic;

// From: http://stackoverflow.com/questions/1273001/net-is-there-a-hasnext-method-for-an-ienumerator

namespace Menus.Lib
{
    public sealed class EnumerableAdapter<T> : IIterable<T>
    {
        private readonly IEnumerable<T> enumerable;

        public EnumerableAdapter(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IIterator<T> Iterator()
        {
            return new EnumeratorAdapter<T>(enumerable.GetEnumerator());
        }
    }
}
