using System;

namespace Project
{
    public interface IGameElement
    {
        int CoordinateX { get; }
        int CoordinateY { get; }

        void Move(int deltaX, int deltaY);
    }

    public class GameElement : IGameElement
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        public GameElement(int initialCoordinateX, int initialCoordinateY)
        {
            CoordinateX = initialCoordinateX;
            CoordinateY = initialCoordinateY;
        }

        public void Move(int deltaX, int deltaY)
        {
            Console.Write($"Moving from ({CoordinateX},{CoordinateY})");
            CoordinateX += deltaX;
            CoordinateY += deltaY;
            Console.WriteLine($"to ({CoordinateX},{CoordinateY})");
        }
    }
}
