using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();

            board.Place('X', 0, 0);
            board.Draw();

            board.Place('Y', 2, 0);
            board.Draw();

            board.Place('X', 2, 2);
            board.Draw();

            board.Place('Y', 1, 1);
            board.Draw();

            board.Place('X', 0, 2);
            board.Draw();

            board.Place('Y', 1, 2);
            board.Draw();

            // Movement that leads to a draw.
            board.Place('X', 1, 0);
            board.Draw();

            board.Place('Y', 0, 1);
            board.Draw();

            board.Place('X', 2, 1);
            board.Draw();

            board.Undo();
            board.Draw();

            board.Undo();
            board.Draw();

            board.Undo();
            board.Draw();

            // Movement that leads to a victory.
            board.Place('X', 0, 1);
            board.Draw();
        }
    }
}
