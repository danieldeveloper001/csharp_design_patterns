using System;
using System.Collections.Generic;
using System.Threading;

namespace Project
{
    public class Game
    {
        private Level _level;
        private IShip _player1;
        private IShip _player2;
        private List<IPowerUpFactory> _powerUpFactories;

        public Game(Level level)
        {
            _level = level;
            _player1 = new Ship("Player 1");
            _player2 = new Ship("Player 2");
            _powerUpFactories = new List<IPowerUpFactory>()
            {
                new LifePowerUpFactory(),
                new ShieldPowerUpFactory(),
                new WeaponPowerUpFactory()
            };
        }

        public void Start()
        {
            while(_player1.Life > 0 && _player2.Life > 0)
            {
                Console.Clear();
                Console.WriteLine("\nPLAYER STATUS");
                Console.WriteLine("=============");
                StatusFor(_player1);
                StatusFor(_player2);

                Console.WriteLine("\nBATTLE STATUS");
                Console.WriteLine("=============");
                HandleDamageFor(_player1, _player2, chance: 0.25);
                HandleDamageFor(_player2, _player1, chance: 0.5);

                Console.WriteLine("\nBONUS STATUS");
                Console.WriteLine("============");
                HandlePowerUpFor(_player1, chance: 0.5);
                HandlePowerUpFor(_player2, chance: 0.25);

                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("\nPLAYER STATUS");
            Console.WriteLine("=============");
            StatusFor(_player1);
            StatusFor(_player2);

            if (_player1.Life > 0)
                Console.WriteLine($"{_player1.Name} Won!");

            if (_player2.Life > 0)
                Console.WriteLine($"{_player2.Name} Won!");
        }

        private void HandleDamageFor(IShip shipToReceiveDamage, IShip shipToInflictDamage, double chance)
        {
            if (!ShouldHandle(chance))
            {
                Console.WriteLine($"'{shipToInflictDamage.Name}' did not damage '{shipToReceiveDamage.Name}' this round!");
                return;
            }

            var expectedBullets = 5 * (new Random().Next(5) + 1);
            var actualBullets = shipToInflictDamage.Shoot(expectedBullets);

            Console.WriteLine($"'{shipToInflictDamage.Name}' damaged '{shipToReceiveDamage.Name}' with {actualBullets} bullets!");
            shipToReceiveDamage.Damage(actualBullets);
        }

        private void HandlePowerUpFor(IShip ship, double chance)
        {
            if (!ShouldHandle(chance))
            {
                Console.WriteLine($"'{ship.Name}' did not receive powerups this round!!");
                return;
            }

            var powerUpFactoryIndex = new Random().Next(_powerUpFactories.Count);
            var powerUpFactory = _powerUpFactories[powerUpFactoryIndex];
            var powerUp = powerUpFactory.Create(_level);

            Console.WriteLine($"'{ship.Name}' received powerup '{powerUp.GetType().Name}' with bonus {powerUp.Bonus}!");
            powerUp.ApplyTo(ship);
        }

        private void StatusFor(IShip ship)
        {
            var life = $"{ship.Life} life";
            var shield = $"{ship.Shield} shield";
            var speed = $"{ship.Speed} speed";
            var weapon = $"{ship.Weapon} weapon";

            Console.WriteLine($"{ship.Name,-15} {life,15}{shield,15}{speed,15}{weapon,15}");
        }
        private bool ShouldHandle(double chance) => new Random().NextDouble() < chance;
    }
}
