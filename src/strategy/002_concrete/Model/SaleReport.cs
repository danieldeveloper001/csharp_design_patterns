using System;
using System.Collections.Generic;

namespace Project
{
    class SaleReport
    {
        private IList<Sale> _sales;
        private ISaleReportSortStrategy _sortStrategy;

        public SaleReport(ISaleReportSortStrategy strategy)
        {
            _sales = new List<Sale>();
            _sortStrategy = strategy;
        }

        public void Add(Sale sale)
        {
            _sales.Add(sale);
        }

        public void Display()
        {
            var sortedSales = _sortStrategy.Execute(_sales);

            Console.WriteLine($"\n{"Product",-20}{"Amount",10}{"Price",10}\n");
            foreach(var sale in sortedSales)
                Console.WriteLine($"{sale.Product,-20}{sale.Amount,10}{sale.Price,10} ");
        }
    }
}
