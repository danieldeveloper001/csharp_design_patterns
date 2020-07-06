using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class SortByProduct : ISaleReportSortStrategy
    {
        public IList<Sale> Execute(IList<Sale> sales) =>
            sales.OrderBy(x => x.Product).ToList();
    }
}
