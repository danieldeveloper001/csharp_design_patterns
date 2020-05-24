using System;
using System.Linq;

namespace Project
{
    public class SpeedPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public SpeedPowerUp(int bonus) => Bonus = bonus;

        public bool IsEquippable(IShip ship)
        {
            var hasShieldPowerUp = ship.PowerUps.Any(p => p.GetType() == typeof(ShieldPowerUp));
            if (hasShieldPowerUp)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(SpeedPowerUp)}' cannot be equipped altogether with {nameof(ShieldPowerUp)}!");
                return false;
            }

            var hasEnoughShield = ship.Speed + Bonus <= 100;
            if (hasEnoughShield)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(SpeedPowerUp)}' cannot be equipped, current '{nameof(ship.Speed)}' is enough!");
                return false;
            }

            Console.WriteLine($"[{ship.Name}] '{nameof(SpeedPowerUp)}' equipped!");
            return true;
        }
    }
}