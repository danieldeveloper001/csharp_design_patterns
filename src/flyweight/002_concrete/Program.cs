using System;

namespace Project
{

    class Hud
    {
        private int _gameColumns;
        private int _gameRows;

        public Hud(int gameColumns, int gameRows)
        {
            _gameColumns = gameColumns;
            _gameRows = gameRows;
        }

        public void Draw(string status)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(0, _gameRows + 1);
            Console.Write('+');
            Console.Write(new string('-', _gameColumns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, _gameRows + 2);
            Console.WriteLine($"| {status, 46} |"); //TODO: _gameColumns - 4

            Console.SetCursorPosition(0, _gameRows + 3);
            Console.Write('+');
            Console.Write(new string('-', _gameColumns - 2));
            Console.Write('+');

            Console.SetCursorPosition(0, Settings.GAME_ROWS + 1);

            Console.Write(new string('-', _gameColumns - 2));

        }
    }

    class Game
    {
        private Action _onStartAction;
        private Action _onEndAction;
        private Hud _hud;
        private Map _map;
        private Player _player;

        public Game(
            Action onStartAction,
            Action onEndAction,
            Hud hud,
            Map map,
            Player player)
        {
            _onStartAction = onStartAction;
            _onEndAction = onEndAction;
            _hud = hud;
            _map = map;
            _player = player;
        }

        public void Start()
        {
            _onStartAction();

            do
            {
                _map.Draw();
                _player.Draw();

                //TODO: MAKE THE HUD LISTEN TO CHANGES ON THE PLAYER POSITION
                var currentBlock = _map.GetBlockAt(_player.Column, _player.Row);
                var status = $"Player is currently at a {currentBlock.Description}";
                _hud.Draw(status);

                ReadNextAction();

            } while(true);

            // _onEndAction();
        }

        private void ReadNextAction()
        {
            //TODO: MAKE GAME UNAWARE OF THE CONSOLE
            var key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.UpArrow:
                    _player.MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    _player.MoveDown();
                    break;
                case ConsoleKey.LeftArrow:
                    _player.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    _player.MoveRight();
                    break;
                case ConsoleKey.Escape:
                    _onEndAction();
                    break;
                default:
                    break;
            }
        }
    }

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


