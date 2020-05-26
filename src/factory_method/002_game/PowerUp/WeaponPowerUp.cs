using System;
using System.Linq;

namespace Project
{
    public class WeaponPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public WeaponPowerUp(int bonus) => Bonus = bonus;

        public bool IsEquippable(IShip ship)
        {
            //TODO: RESOLVE MAGIC NUMBER '1000' (MAX SHIP WEAPON)
            var isEquippable = ship.Weapon + Bonus <= 1000;
            if (!isEquippable)
                Bonus = 1000 - ship.Weapon;

            return true;
        }
    }
}