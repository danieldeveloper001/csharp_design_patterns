using System;

namespace Project
{
    class Singleton
    {
        private static Singleton _singleton = new Singleton();

        private Singleton() {}

        public static Singleton GetInstance() => _singleton;
    }
}
