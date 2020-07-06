using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameElement = new GameElement(0, 0);
            var gameTurn = new GameTurn();

            gameTurn.Add(new MovementAction(gameElement, 10, 0));
            gameTurn.Add(new MovementAction(gameElement, 0, 10));
            gameTurn.Add(new MovementAction(gameElement, -20, 0));
            gameTurn.Add(new MovementAction(gameElement, 0, -20));
            gameTurn.Add(new MovementAction(gameElement, 20, 0));
            gameTurn.Add(new MovementAction(gameElement, 0, 10));
            gameTurn.Add(new MovementAction(gameElement, -10, 0));

            gameTurn.Execute();
        }
    }
}
