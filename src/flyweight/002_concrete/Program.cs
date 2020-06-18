using System;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapBlockFactory = new MapBlockFactory();

            //TODO: REFACTOR
            var playerX = 0;
            var playerY = 0;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            do
            {
                //TODO: IN MEMORY MAP
                using (var reader = new StreamReader("./Maps/Level1.txt"))
                {
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
                }

                //TODO: REFACTOR
                Console.SetCursorPosition(playerX, playerY);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\u263A");

                var key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if(playerY > 0)
                            playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if(playerY < 25)
                            playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if(playerX > 0)
                            playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if(playerX < 50)
                            playerX++;
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.CursorVisible = true;
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while(true);
        }
    }
}

