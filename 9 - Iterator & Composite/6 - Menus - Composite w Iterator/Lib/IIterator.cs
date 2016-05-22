using System;

// From: http://stackoverflow.com/questions/1273001/net-is-there-a-hasnext-method-for-an-ienumerator

namespace Menus.Lib
{
    // Mimics Java's Iterator interface - but
    // implements IDisposable for the sake of
    // parity with IEnumerator.
    public interface IIterator<T> : IDisposable
    {
        bool HasNext();
        T Next();
        void Remove();
    }
}
