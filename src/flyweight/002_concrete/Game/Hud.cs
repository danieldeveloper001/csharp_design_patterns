using System;

namespace Project
{
    public class Hud
    {
        public void Draw(string status)
        {
            var columns = Settings.GAME_COLUMNS;
            var rows = Settings.GAME_ROWS;

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(0, rows + 1);
            Console.Write('+');
            Console.Write(new string('-', columns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, rows + 2);
            Console.WriteLine($"| {status, 46} |"); //TODO: 46 = _gameColumns - 4

            Console.SetCursorPosition(0, rows + 3);
            Console.Write('+');
            Console.Write(new string('-', columns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, Settings.GAME_ROWS + 1);

            Console.Write(new string('-', columns - 2));
        }
    }
}