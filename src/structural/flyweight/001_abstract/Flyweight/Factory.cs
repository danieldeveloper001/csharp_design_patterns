using System;
using System.Collections.Generic;

namespace Project
{
    public class Factory
    {
        private Dictionary<string, IFlyweight> _cache;

        public Factory()
        {
            _cache = new Dictionary<string, IFlyweight>();
        }

        public IFlyweight Get(string key)
        {
            if (!_cache.ContainsKey(key))
            {
                switch(key)
                {
                    case "flyweight1":
                        Console.WriteLine($"{nameof(Flyweight1)} instance added to the cache!");
                        _cache[key] = new Flyweight1();
                        break;
                    case "flyweight2":
                        Console.WriteLine($"{nameof(Flyweight2)} instance added to the cache!");
                        _cache[key] = new Flyweight2();
                        break;
                    case "flyweight3":
                        Console.WriteLine($"{nameof(Flyweight3)} instance added to the cache!");
                        _cache[key] = new Flyweight3();
                        break;
                    default:
                        throw new Exception();
                }
            }

            return _cache[key];
        }
    }
}