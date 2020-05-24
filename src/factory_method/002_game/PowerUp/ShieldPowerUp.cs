using System;
using System.Linq;

namespace Project
{
    public class ShieldPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public ShieldPowerUp(int bonus) => Bonus = bonus;

        public bool IsEquippable(IShip ship)
        {
            var hasSpeedPowerUp = ship.PowerUps.Any(p => p.GetType() == typeof(SpeedPowerUp));
            if (hasSpeedPowerUp)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(ShieldPowerUp)}' cannot be equipped altogether with {nameof(SpeedPowerUp)}!");
                return false;
            }

            var hasEnoughShield = ship.Shield + Bonus <= 100;
            if (hasEnoughShield)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(ShieldPowerUp)}' cannot be equipped, current '{nameof(ship.Shield)}' is enough!");
                return false;
            }

            Console.WriteLine($"[{ship.Name}] '{nameof(ShieldPowerUp)}' equipped!");
            return true;
        }
    }
}