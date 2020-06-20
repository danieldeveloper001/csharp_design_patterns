using System;

namespace Project
{
    public class Game
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
                _hud.Draw($"Player is currently at a {currentBlock.Description}");

            } while(ReadNextAction());

            _onEndAction();
        }

        private bool ReadNextAction()
        {
            var hasNextAction = true;

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
                    hasNextAction = false;
                    break;
                default:
                    break;
            }

            return hasNextAction;
        }
    }
}