using System;

namespace Project
{
    class Singleton
    {
        private static Singleton _singleton;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (_singleton is null)
                _singleton = new Singleton();

            return _singleton;
        }
    }
}
