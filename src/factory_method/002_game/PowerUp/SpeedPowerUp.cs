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
            //TODO: RESOLVE MAGIC NUMBER '100' (MAX SHIP SPEED)
            var isEquippable = ship.Speed + Bonus >= 100;
            if (!isEquippable)
                Bonus = 100 - ship.Speed;

            return true;
        }
    }
}