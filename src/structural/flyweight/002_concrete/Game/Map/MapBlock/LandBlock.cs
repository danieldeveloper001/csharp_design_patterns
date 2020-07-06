using System;

namespace Project
{
    public class LandBlock : IMapBlock
    {

        public string Description { get; private set; }
        private ConsoleColor _color;

        public LandBlock()
        {
            Description = "Land Block";
            _color = ConsoleColor.DarkYellow;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(x, y);
            Console.Write("▓");
        }
    }
}