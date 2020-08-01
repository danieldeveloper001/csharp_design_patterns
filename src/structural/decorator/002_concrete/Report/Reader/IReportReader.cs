using System;
using System.Collections.Generic;

namespace Project
{
    interface IReportReader
    {
        IEnumerable<Report> Read(string path);
    }
}
