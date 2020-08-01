using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class ReportReaderCache : IReportReader
    {
        private IDictionary<string, IEnumerable<Report>> _cache;
        private IReportReader _reportReader;

        public ReportReaderCache(IReportReader ReportReader)
        {
            _cache = new Dictionary<string, IEnumerable<Report>>();
            _reportReader = ReportReader;
        }

        public IEnumerable<Report> Read(string path)
        {
            var filename = Path.GetFileNameWithoutExtension(path);
            if (_cache.Keys.Contains(filename))
            {
                Console.WriteLine($"[{DateTime.Now}] Reading from report cache...");
                return _cache[filename];
            }

            var report = _reportReader.Read(path);
            _cache.Add(filename, report);

            return report;
        }

    }
}
