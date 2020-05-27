using System;
using System.Linq;

namespace Project
{
    public class ShieldPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public ShieldPowerUp(int bonus)
            => Bonus = bonus;

        public void ApplyTo(IShip ship)
            => ship.Defend(Bonus);
    }
}