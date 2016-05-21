using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public interface IMenu : IEnumerable<MenuItem>
    {
        // Not really needed, since in place of it you can just implement the IEnumerable<T> interface.
        // But this is a bit shorter and stays a bit closer to the example ...
        
        //IEnumerator<MenuItem> GetEnumerator();
    }
}
