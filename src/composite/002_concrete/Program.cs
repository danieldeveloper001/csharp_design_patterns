using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearReport = new Report("2000");

            var janReport = new Report("JAN");
            janReport.Add(new Sale("Product 1", 10.0m, 100));
            janReport.Add(new Sale("Product 2", 20.0m, 200));
            janReport.Add(new Sale("Product 3", 30.0m, 300));

            var febReport = new Report("FEB");
            febReport.Add(new Sale("Product 1", 15.0m, 50));
            febReport.Add(new Sale("Product 2", 30.0m, 100));
            febReport.Add(new Sale("Product 3", 45.0m, 150));

            var marReport = new Report("MAR");
            marReport.Add(new Sale("Product 1", 12.5m, 75));
            marReport.Add(new Sale("Product 2", 25.0m, 150));
            marReport.Add(new Sale("Product 3", 37.5m, 225));

            yearReport.Add(janReport);
            yearReport.Add(febReport);
            yearReport.Add(marReport);

            // Composite makes possible for any item being handled uniformly by the client
            yearReport.Display();
            // janReport.Display();
            // febReport.Display();
            // marReport.Display();
        }
    }
}
