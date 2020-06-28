using System;
using System.Collections.Generic;

namespace Project
{
    public class ProxyService : IService
    {
        private Dictionary<int, string> _cache;
        private RealService _service;

        private string _path;

        public ProxyService(string path)
        {
            _cache = new Dictionary<int, string>();
            _service = new RealService(path);

            _path = path;
        }

        public bool TryGet(int rowIndex, out string rowData)
        {
            if (_cache.ContainsKey(rowIndex))
            {
                Console.WriteLine("Consuming cached data...");
                rowData = _cache[rowIndex];
                return true;
            }

            var rowResult = _service.TryGet(rowIndex, out rowData);
            _cache.Add(rowIndex, rowData);

            return rowResult;
        }
    }
}