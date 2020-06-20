using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(
                onStartAction: ConsoleSetup,
                onEndAction: ConsoleTeardown,
                hud: new Hud(),
                map: new Map(new MapBlockFactory()),
                player: new Player());

            game.Start();
        }

        private static void ConsoleSetup()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
        }

        private static void ConsoleTeardown()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Environment.Exit(0);
        }
    }
}


