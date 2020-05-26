using System;
using System.Collections.Generic;
using System.Threading;

namespace Project
{
    public class Game
    {
        private Level _level;
        private IShip _playerShip;
        private IShip _enemyShip;
        private List<IPowerUpFactory> _powerUpFactories;

        public Game(Level level)
        {
            _level = level;
            _playerShip = new Ship("Player");
            _enemyShip = new Ship("Enemy");
            _powerUpFactories = new List<IPowerUpFactory>()
            {
                new LifePowerUpFactory(),
                new ShieldPowerUpFactory(),
                new WeaponPowerUpFactory()
            };
        }

        public void Start()
        {
            while(_playerShip.Life > 0 && _enemyShip.Life > 0)
            {
                HandlePowerUpFor(_playerShip, chance: 0.5);
                HandlePowerUpFor(_enemyShip, chance: 0.25);

                HandleDamageFor(_playerShip, _enemyShip, chance: 0.25);
                HandleDamageFor(_enemyShip, _playerShip, chance: 0.5);

                StatusFor(_playerShip);
                StatusFor(_enemyShip);

                Thread.Sleep(500);
            }

            if (_playerShip.Life > 0)
                Console.WriteLine("Player Won!");

            if (_enemyShip.Life > 0)
                Console.WriteLine("Enemy Won!");
        }

        private void HandleDamageFor(IShip shipToReceiveDamage, IShip shipToInflictDamage, double chance)
        {
            if (!ShouldHandle(chance))
                return;

            var expectedBullets = 5 * (new Random().Next(5) + 1);
            var actualBullets = shipToInflictDamage.Shoot(expectedBullets);
            shipToReceiveDamage.Damage(actualBullets);
        }

        private void HandlePowerUpFor(IShip ship, double chance)
        {
            if (!ShouldHandle(chance))
                return;

            var powerUpFactoryIndex = new Random().Next(_powerUpFactories.Count);
            var powerUpFactory = _powerUpFactories[powerUpFactoryIndex];
            var powerUp = powerUpFactory.Create(_level);

            ship.PowerUp(powerUp);
        }

        private void StatusFor(IShip ship)
        {
            var life = $"{ship.Life} life";
            var shield = $"{ship.Shield} shield";
            var speed = $"{ship.Speed} speed";
            var weapon = $"{ship.Weapon} weapon";

            Console.WriteLine($"[{ship.Name}] {life,-15}{shield,-15}{speed,-15}{weapon,-15}");
        }
        private bool ShouldHandle(double chance) => new Random().NextDouble() < chance;
    }
}
