using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new SaleReport(new SortByPrice());

            report.Add(new Sale("Product 1", 100, 3000));
            report.Add(new Sale("Product 2", 200, 2000));
            report.Add(new Sale("Product 3", 300, 1000));

            report.Display();
        }
    }
}
