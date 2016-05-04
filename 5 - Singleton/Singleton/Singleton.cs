using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
     /// <summary>
    /// Uses 'lazy instantiation', which saves system resources until the object actually needs to be created.
    /// </summary>
    public class Singleton
    {
        private static Singleton uniqueInstance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
