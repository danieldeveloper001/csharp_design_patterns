using System;

namespace Project
{
    public class SandBlock : IMapBlock
    {

        public string Description { get; private set; }
        private ConsoleColor _color;

        public SandBlock()
        {
            Description = "Sand Block";
            _color = ConsoleColor.Yellow;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(x, y);
            Console.Write("▒");
        }
    }
}