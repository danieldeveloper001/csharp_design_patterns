using System;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapBlockFactory = new MapBlockFactory();

            using (var reader = new StreamReader("./Maps/Level3.txt"))
            {
                Console.Clear();

                var rowIndex = 0;
                while (reader.ReadLine() is string row)
                {
                    var columnIndex = 0;
                    while(columnIndex < row.Length && row[columnIndex] is char column)
                    {
                        var block = mapBlockFactory.GetMapBlock(column);
                        block.Draw(columnIndex, rowIndex);

                        columnIndex++;
                    }

                    rowIndex++;
                }

                Console.WriteLine();
            }
        }
    }
}

