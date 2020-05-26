using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Ship : IShip
    {
        public string Name { get; }

        public int Life { get; private set; }
        public int Shield { get; private set; }
        public int Speed { get; private set; }
        public int Weapon { get; private set; }

        public Ship(
            string name,
            int life = 100,
            int shield = 50,
            int speed = 50,
            int weapon = 500)
        {
            Name = name;
            Life = life;
            Shield = shield;
            Speed = speed;
            Weapon = weapon;
        }

        public void Accelerate(int amount)
        {
            Speed = (amount + Speed <= 100) ? amount + Speed : 100;
        }

        public void Damage(int amount)
        {
            bool hasShield = Shield > 0;
            if (hasShield)
            {
                HandleShieldDamage(amount);
                return;
            }

            HandleLifeDamage(amount);
        }

        public void Defend(int amount)
        {
            Shield = (amount + Shield <= 100) ? amount + Shield : 100;
        }

        public void Heal(int amount)
        {
            Life = (amount + Life <= 100) ? amount + Life : 100;
        }

        public void Reload(int amount)
        {
            Weapon = (amount + Weapon <= 1000) ? amount + Weapon : 1000;
        }

        public int Shoot(int amount)
        {
            Weapon -= amount;

            bool wasWeaponEnough = Weapon >= 0;
            if (!wasWeaponEnough)
                return amount - Math.Abs(Weapon);

            return amount;
        }

        private void HandleShieldDamage(int amount)
        {
            Shield -= amount;

            bool wasShieldEnough = Shield >= 0;
            if (!wasShieldEnough)
            {
                amount = Math.Abs(Shield);
                Shield = 0;
                HandleLifeDamage(amount);
            }
        }

        private void HandleLifeDamage(int amount)
        {
            Life -= amount;

            bool wasLifeEnough = Life >= 0;
            if (!wasLifeEnough)
                Life = 0;
        }

    }
}