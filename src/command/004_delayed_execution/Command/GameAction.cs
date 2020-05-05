using System;

namespace Project
{
    public interface IGameAction
    {
        IGameElement GameElement { get; }

        void Execute();
    }

    public class MovementAction : IGameAction
    {
        public IGameElement GameElement { get; private set; }
        public int DeltaX { get; private set; }
        public int DeltaY { get; private set; }

        public MovementAction(IGameElement gameElement, int deltaX, int deltaY)
        {
            GameElement = gameElement;
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        public void Execute() => GameElement.Move(DeltaX, DeltaY);
    }

    //TODO: IMPLEMENT OTHER GAME ELEMENT ACTIONS

}
