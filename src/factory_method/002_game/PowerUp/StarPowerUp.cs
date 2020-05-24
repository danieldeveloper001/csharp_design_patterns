using System;
using System.Linq;

namespace Project
{
    public class StarPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public StarPowerUp(int bonus) => Bonus = bonus;

        public bool IsEquippable(IShip ship)
        {
            var hasStarPowerUp = ship.PowerUps.Any(x => x.GetType() == typeof(StarPowerUp));
            if (hasStarPowerUp)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(StarPowerUp)}' cannot be equipped twice!");
                return false;
            }

            Console.WriteLine($"[{ship.Name}] '{nameof(StarPowerUp)}' equipped!");
            return true;
        }
    }
}