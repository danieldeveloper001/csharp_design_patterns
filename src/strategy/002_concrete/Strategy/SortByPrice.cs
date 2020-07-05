using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class SortByPrice : ISaleReportSortStrategy
    {
        public IList<Sale> Execute(IList<Sale> sales) =>
            sales.OrderBy(x => x.Price).ToList();
    }
}
