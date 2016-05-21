using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class DinerMenuIteratorAlternating : IEnumerator<MenuItem>
    {
        int _position = 0;

        MenuItem[] _items;

        public DinerMenuIteratorAlternating(MenuItem[] item)
        {
            _items = item;
            _position = (int)DateTime.Now.DayOfWeek % 2;
        }

        public MenuItem Current
        {
            get
            {
                return getNext();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return getNext();
            }
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            return (_position < (_items.Length - 1) && _items[_position] != null);
        }

        public void Reset()
        {
            _position = 0;
        }


        private MenuItem getNext()
        {
            MenuItem menuItem = _items[_position];
            _position += 2;
            return menuItem;
        }
    }
}
