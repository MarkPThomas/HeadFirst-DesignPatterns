using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Uses 'double-checked locking' to only lock the object against manipulation against other threads only the first time the instantiation method is called.
    /// This is the only time it is needed, so it doesn't have much of a speed penalty.
    /// See: http://stackoverflow.com/questions/541194/c-sharp-version-of-javas-synchronized-keyword
    /// And: http://stackoverflow.com/questions/6140048/difference-between-manual-locking-and-synchronized-methods?lq=1
    /// </summary>
    class SingletonThreadSafeSync
    {
        private static SingletonThreadSafeSync uniqueInstance;

        private SingletonThreadSafeSync() { }

  
        public static SingletonThreadSafeSync GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (uniqueInstance)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new SingletonThreadSafeSync();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}
