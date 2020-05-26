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
            bool hasShield = _shield > 0;
            if (hasShield)
            {
                HandleShieldDamage(amount);
                return;
            }

            HandleLifeDamage(amount);
        }

        public int Shoot(int amount)
        {
            _weapon -= amount;

            bool wasWeaponEnough = _weapon >= 0;
            if (!wasWeaponEnough)
                return amount - Math.Abs(_weapon);

            return amount;
        }

        private void HandleShieldDamage(int amount)
        {
            _shield -= amount;

            bool wasShieldEnough = _shield >= 0;
            if (!wasShieldEnough)
            {
                amount = Math.Abs(_shield);
                _shield = 0;
                HandleLifeDamage(amount);
            }
        }

        private void HandleLifeDamage(int amount)
        {
            _life -= amount;

            bool wasLifeEnough = _life >= 0;
            if (!wasLifeEnough)
                _life = 0;
        }
    }
}