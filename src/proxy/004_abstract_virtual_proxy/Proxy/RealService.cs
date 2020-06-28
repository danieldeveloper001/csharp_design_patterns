using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project
{
    public class RealService : IService
    {
        private string _path;

        public RealService(string path)
        {
            _path = path;
        }

        public bool TryGet(int rowIndex, out string rowData)
        {
            Console.WriteLine("Consuming file data...");

            var allData = new List<String>();
            using(var stream = new StreamReader(_path))
                allData = stream.ReadToEnd().Split('\n').ToList();

            rowData = allData.ElementAtOrDefault(rowIndex);
            return String.IsNullOrWhiteSpace(rowData);
        }
    }
}