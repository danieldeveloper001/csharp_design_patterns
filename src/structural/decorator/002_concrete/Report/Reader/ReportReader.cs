using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class ReportReader : IReportReader
    {
        public ReportReader() { }

        public IEnumerable<Report> Read(string path)
        {
            var report = new List<Report>();

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(';');
                    report.Add(
                        new Report()
                        {
                            Id = Guid.Parse(line[0]),
                            Product = line[1],
                            Amount = Int32.Parse(line[2]),
                            Value = Decimal.Parse(line[3])
                        });
                }
            }

            return report;
        }
    }
}
