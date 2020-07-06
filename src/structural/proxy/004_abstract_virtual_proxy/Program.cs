using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ProxyService("./Data/20200101_report.csv"));
            client.TryGet(0, out string rowData0);
            Console.WriteLine($"{nameof(rowData0)}: {rowData0}");

            client.TryGet(1, out string rowData1);
            Console.WriteLine($"{nameof(rowData1)}: {rowData1}");

            client.TryGet(2, out string rowData20);
            Console.WriteLine($"{nameof(rowData20)}: {rowData20}");

            client.TryGet(2, out string rowData21);
            Console.WriteLine($"{nameof(rowData21)}: {rowData21}");

            client.TryGet(2, out string rowData22);
            Console.WriteLine($"{nameof(rowData22)}: {rowData22}");
        }
    }
}
