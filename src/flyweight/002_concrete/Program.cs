using System;
using System.IO;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleSetup();

            var map = new Map(new MapBlockFactory(), Settings.MAP_COLUMNS, Settings.MAP_ROWS);
            map.Load(Settings.MAP_PATH);

            var player = new Player();

            do
            {
                map.Draw();
                player.Draw();

                var currentBlock = map.GetBlockAt(player.Column, player.Row);

                var message = $"Player is currently at a {currentBlock.Description}";
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, Settings.MAP_ROWS + 1);
                Console.WriteLine($"\n{message, 50}");


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

