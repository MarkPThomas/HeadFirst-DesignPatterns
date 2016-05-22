// From: http://stackoverflow.com/questions/1273001/net-is-there-a-hasnext-method-for-an-ienumerator

namespace Menus.Lib
{
    // // Mimics Java's Iterable<T> interface
    public interface IIterable<T>
    {
        IIterator<T> Iterator();
    }
}
