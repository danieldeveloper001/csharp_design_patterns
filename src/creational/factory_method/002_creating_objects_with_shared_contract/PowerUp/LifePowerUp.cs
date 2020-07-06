using System;
using System.Linq;

namespace Project
{
    public class LifePowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public LifePowerUp(int bonus) => Bonus = bonus;

        public void ApplyTo(IShip ship)
            => ship.Heal(Bonus);
    }
}