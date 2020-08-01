using System;
using System.Collections.Generic;

namespace Project
{
    class ReportReaderLogger : IReportReader
    {
        private IReportReader _reportReader;

        public ReportReaderLogger(IReportReader ReportReader)
        {
            _reportReader = ReportReader;
        }

        public IEnumerable<Report> Read(string path)
        {
            Console.WriteLine($"[{DateTime.Now}] Reading report file...");
            var report = _reportReader.Read(path);
            Console.WriteLine($"[{DateTime.Now}] Done.");

            return report;
        }
    }
}
