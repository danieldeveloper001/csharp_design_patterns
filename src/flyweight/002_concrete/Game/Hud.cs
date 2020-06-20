using System;

namespace Project
{
    public class Hud
    {
        private int _gameColumns;
        private int _gameRows;

        public Hud(int gameColumns, int gameRows)
        {
            _gameColumns = gameColumns;
            _gameRows = gameRows;
        }

        public void Draw(string status)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(0, _gameRows + 1);
            Console.Write('+');
            Console.Write(new string('-', _gameColumns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, _gameRows + 2);
            Console.WriteLine($"| {status, 46} |"); //TODO: _gameColumns - 4

            Console.SetCursorPosition(0, _gameRows + 3);
            Console.Write('+');
            Console.Write(new string('-', _gameColumns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, Settings.GAME_ROWS + 1);

            Console.Write(new string('-', _gameColumns - 2));
        }
    }
}