using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;

namespace Menus.Model
{
    /// <summary>
    /// This iterator always returns false, such that it is not iterated over.
    /// This is more robust than returning 'null', which would then require null checks by the client.
    /// </summary>
    class NullIterator : IIterator<MenuComponent>
    {
        public MenuComponent Next()
        {
            return null;
        }

        public void Dispose()
        {
            // No action.
        }

        public bool HasNext()
        {
            return false;
        }

        public void Reset()
        {
            // No action.
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
