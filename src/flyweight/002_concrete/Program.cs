using System;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSetup();

            var player = new Player();
            var mapBlockFactory = new MapBlockFactory();
            do
            {
                //TODO: IN MEMORY MAP
                using (var reader = new StreamReader("./Maps/Level1.txt"))
                {
                    var currentBlockDescription = String.Empty;
                    var rowIndex = 0;
                    while (reader.ReadLine() is string row)
                    {
                        var columnIndex = 0;
                        while(columnIndex < row.Length && row[columnIndex] is char column)
                        {
                            var block = mapBlockFactory.GetMapBlock(column);
                            block.Draw(columnIndex, rowIndex);

                            if (player.X == columnIndex && player.Y == rowIndex)
                                currentBlockDescription = block.Description;

                            columnIndex++;
                        }

                        rowIndex++;
                    }
                    var message = $"Player is currently at a {currentBlockDescription}";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n{message, 50}");
                }

                //TODO: REFACTOR
                Console.SetCursorPosition(player.X, player.Y);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\u263A");

                var key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        player.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        player.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        player.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        player.MoveRight();
                        break;
                    case ConsoleKey.Escape:
                        ConsoleTeardown();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while(true);
        }

        private static void ConsoleSetup()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
        }

        private static void ConsoleTeardown()
        {
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}

