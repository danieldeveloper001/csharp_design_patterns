using System;

namespace Project
{
    class Singleton
    {
        private static readonly object _padlock = new object();
        private static Singleton _singleton;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            // The double checking approach prevents requests for the instance from being locked on multiple threads
            // when the singleton instance was already previously created, improving its performance on subsequent calls
            if (_singleton is null)
            {
                lock(_padlock)
                {
                    if (_singleton is null)
                    {
                        _singleton = new Singleton();
                    }
                }
            }

            return _singleton;
        }
    }
}
