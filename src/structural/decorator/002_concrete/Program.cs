using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IReportReader reportReader;
            reportReader = new ReportReader();
            reportReader = new ReportReaderCache(reportReader);
            reportReader = new ReportReaderLogger(reportReader);

            var report1 = reportReader.Read("./Data/20200101_report.csv");
            var report2 = reportReader.Read("./Data/20200102_report.csv");
            var report3 = reportReader.Read("./Data/20200103_report.csv");

            report1 = reportReader.Read("./Data/20200101_report.csv");
            report2 = reportReader.Read("./Data/20200102_report.csv");
            report3 = reportReader.Read("./Data/20200103_report.csv");
        }
    }
}
