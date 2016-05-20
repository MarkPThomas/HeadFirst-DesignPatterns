using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class PancakeHouseMenuIterator : IIterator
    {

        int position = 0;


        List<MenuItem> _items;

        public PancakeHouseMenuIterator(List<MenuItem> item)
        {
            _items = item;
        }

        public bool HasNext()
        {
            return (position < (_items.Count) && _items[position] != null);
        }

        public object Next()
        {
            MenuItem menuItem = _items[position];
            position += 1;
            return menuItem;
        }
    }
}
