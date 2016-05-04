using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Singleton
{
    /// <summary>
    ///  Uses a thread-safe sync on the method. 
    ///  However, this has large speed performance penalties and is really only necessary the first time the method is called.
    ///  See: http://stackoverflow.com/questions/541194/c-sharp-version-of-javas-synchronized-keyword
    ///  And: http://stackoverflow.com/questions/6140048/difference-between-manual-locking-and-synchronized-methods?lq=1
    /// </summary>
    class SingletonThreadSafeSyncAll
    {
        private static SingletonThreadSafeSyncAll uniqueInstance;

        private SingletonThreadSafeSyncAll() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonThreadSafeSyncAll GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new SingletonThreadSafeSyncAll();
            }
            return uniqueInstance;
        }
    }
}
