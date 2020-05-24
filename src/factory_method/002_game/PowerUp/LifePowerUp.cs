using System;
using System.Linq;

namespace Project
{
    public class LifePowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public LifePowerUp(int bonus) => Bonus = bonus;

        public bool IsEquippable(IShip ship)
        {
            var hasEnoughLife = ship.Life + Bonus <= 100;
            if (hasEnoughLife)
            {
                Console.WriteLine($"[{ship.Name}] '{nameof(LifePowerUp)}' cannot be equipped, current '{nameof(ship.Life)}' is enough!");
                return false;
            }

            Console.WriteLine($"[{ship.Name}] '{nameof(LifePowerUp)}' equipped!");
            return true;
        }
    }
}