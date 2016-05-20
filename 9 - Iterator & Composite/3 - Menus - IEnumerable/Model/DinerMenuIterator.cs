using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {

        int position = 0;

        MenuItem[] _items;

        public DinerMenuIterator(MenuItem[] item)
        {
            _items = item;
        }

        public object Current
        {
            get
            {
                return getNext();
            }
        }

        MenuItem IEnumerator<MenuItem>.Current
        {
            get
            {
                return getNext();
            }
        }

        public bool MoveNext()
        {
            return (position < (_items.Length - 1) && _items[position] != null);
        }

        public void Reset()
        {
            position = 0;
        }

        public void Dispose()
        {
            Reset();
        }

        private MenuItem getNext()
        {
            MenuItem menuItem = _items[position];
            position += 1;
            return menuItem;
        }
    }
}
