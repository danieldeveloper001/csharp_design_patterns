using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var hud = new Hud(Settings.GAME_COLUMNS, Settings.GAME_ROWS);

            var map = new Map(new MapBlockFactory(), Settings.GAME_COLUMNS, Settings.GAME_ROWS);
            map.Load(Settings.MAP_PATH);

            var player = new Player();

            var game = new Game(
                onStartAction: ConsoleSetup,
                onEndAction: ConsoleTeardown,
                hud: hud,
                map: map,
                player: player);

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
        }
    }
}


