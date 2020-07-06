using System;
using System.Collections.Generic;

namespace Project
{
    interface ISaleReportSortStrategy
    {
        IList<Sale> Execute(IList<Sale> sales);
    }
}
