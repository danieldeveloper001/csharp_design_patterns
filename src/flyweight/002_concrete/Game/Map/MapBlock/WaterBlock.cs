using System;

namespace Project
{
    public class WaterBlock : IMapBlock
    {

        public string Description { get; private set; }
        private ConsoleColor _color;

        public WaterBlock()
        {
            Description = "Water Block";
            _color = ConsoleColor.Blue;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(x, y);
            Console.Write("░");
        }
    }
}