using System;

namespace Project
{
    public class Player
    {
        public int Column { get; private set; }
        public int Row { get; private set; }

        public void Draw()
        {
            Console.SetCursorPosition(Column, Row);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("☺");
        }

        public void MoveUp()
        {
            if(Row > 0) Row--;
        }

        public void MoveDown()
        {
            if(Row < Settings.GAME_ROWS - 1) Row++;
        }

        public void MoveLeft()
        {
            if(Column > 0) Column--;
        }

        public void MoveRight()
        {
            if(Column < Settings.GAME_COLUMNS - 1) Column++;
        }
    }
}