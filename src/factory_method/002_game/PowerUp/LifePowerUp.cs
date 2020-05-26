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
            //TODO: RESOLVE MAGIC NUMBER '100' (MAX SHIP LIFE)
            var isEquippable = ship.Life + Bonus <= 100;
            if (!isEquippable)
                Bonus = 100 - ship.Life;

            return true;
        }
    }
}