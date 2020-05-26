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
            //TODO: RESOLVE MAGIC NUMBER '100' (MAX SHIP SHIELD)
            var isEquippable = ship.Shield + Bonus <= 50;
            if (!isEquippable)
                Bonus = 100 - ship.Shield;

            return true;
        }
    }
}