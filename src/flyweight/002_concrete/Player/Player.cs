using System;

namespace Project
{
    //TODO: PLAYER SHOULDN'T BE AWARE OF MAP SIZE
    public class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public void MoveUp()
        {
            if(Y > 0) Y--;
        }

        public void MoveDown()
        {
            if(Y < 25) Y++;
        }

        public void MoveLeft()
        {
            if(X > 0) X--;
        }

        public void MoveRight()
        {
            if(X < 50) X++;
        }
    }
}