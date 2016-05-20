using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class DinerMenuIterator : IIterator
    {

        int position = 0;

        MenuItem[] _items;

        public DinerMenuIterator(MenuItem[] item)
        {
            _items = item;
        }

        public bool HasNext()
        {
            return (position < (_items.Length - 1) && _items[position] != null);
        }

        public object Next()
        {
            MenuItem menuItem = _items[position];
            position += 1;
            return menuItem;
        }
    }
}
