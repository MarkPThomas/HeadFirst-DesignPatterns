using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Uses 'active instantiation' to avoid the possibility of multiple instances being created from multiple threads.
    /// </summary>
    class SingletonThreadSafeActive
    {
        private static SingletonThreadSafeActive uniqueInstance = new SingletonThreadSafeActive();

        private SingletonThreadSafeActive() { }

        public static SingletonThreadSafeActive GetInstance()
        {
            return uniqueInstance;
        }
    }
}
