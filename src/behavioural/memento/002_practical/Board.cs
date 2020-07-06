using System;
using System.Threading;

namespace Project
{
    public class Board
    {
        public char[,] Positions { get; private set; }
        private BoardHistory _history;

        public Board()
        {
            Positions = new char[3,3];
            _history = new BoardHistory();
        }

        public void Place(char player, int x, int y)
        {
            var snapshot = new BoardSnapshot(Positions);
            _history.Do(snapshot);

            Positions[x,y] = player;
        }

        public void Undo()
        {
            var snapshot = _history.Undo();
            Positions = snapshot.Positions;
        }

        public void Draw()
        {
            Thread.Sleep(1000);
            Console.Clear();

            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    char position = Positions[j,i];
                    bool isPositionEmpty = (position == Char.MinValue);

                    bool isLastColumn = (j == 2);
                    Console.Write($" {(isPositionEmpty ? ' ' : position)} {(isLastColumn ? "\n" : "|")}");
                }
                bool isLastRow = (i == 2);
                Console.Write($"{(isLastRow ? "\n" : "---+---+---\n")}");
            }
        }
    }
}