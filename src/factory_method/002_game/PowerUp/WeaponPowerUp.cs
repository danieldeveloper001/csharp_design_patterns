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
            var hasEnoughWeapon = ship.Weapon + Bonus <= 1000;
            if (hasEnoughWeapon)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(WeaponPowerUp)}' cannot be equipped, current '{nameof(ship.Weapon)}' is enough!");
                return false;
            }

            Console.WriteLine($"[{ship.Name}] '{nameof(WeaponPowerUp)}' equipped!");
            return true;
        }
    }
}