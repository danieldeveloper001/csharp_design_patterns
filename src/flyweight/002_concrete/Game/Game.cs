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
}