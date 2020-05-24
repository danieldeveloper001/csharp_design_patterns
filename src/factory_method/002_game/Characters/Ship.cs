using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Ship : IShip
    {
        public IList<IPowerUp> PowerUps { get; }
        public string Name { get; }

        private int _life;
        public int Life => _life + PowerUps
            .Where(p => p.GetType() == typeof(LifePowerUp))
            .Sum(p => p.Bonus);

        private int _shield;
        public int Shield => _shield + PowerUps
            .Where(p => p.GetType() == typeof(ShieldPowerUp))
            .Sum(p => p.Bonus);

        private int _speed;
        public int Speed => _speed + PowerUps
            .Where(p => p.GetType() == typeof(SpeedPowerUp))
            .Sum(p => p.Bonus);

        private int _weapon;
        public int Weapon => _weapon + PowerUps
            .Where(p => p.GetType() == typeof(WeaponPowerUp))
            .Sum(p => p.Bonus);

        public Ship(
            string name,
            int life = 100,
            int shield = 50,
            int speed = 50,
            int weapon = 500)
        {
            PowerUps = new List<IPowerUp>();
            Name = name;
            _life = life;
            _shield = shield;
            _speed = speed;
            _weapon = weapon;
        }

        public void PowerUp(IPowerUp powerUp)
        {
            if (!powerUp.IsEquippable(this))
                return;

            Console.WriteLine($"[PowerUp] {powerUp.GetType().Name} received!");
            PowerUps.Add(powerUp);
        }

        public void Damage(int amount)
        {
            if (_shield > 0)
            {
                bool hasEnoughShield = _shield < amount;
                _shield -= hasEnoughShield ? amount : 0;

                return;
            }

            if (_life < amount)
            {
                _life = 0;
                return;
            }

            _life -= amount;
        }

        public bool IsAlive() => Life > 0;
    }
}