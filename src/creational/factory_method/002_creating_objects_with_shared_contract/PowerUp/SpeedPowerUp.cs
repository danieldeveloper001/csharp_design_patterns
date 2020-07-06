using System;
using System.Linq;

namespace Project
{
    public class SpeedPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public SpeedPowerUp(int bonus)
            => Bonus = bonus;

        public void ApplyTo(IShip ship)
            => ship.Accelerate(Bonus);
    }
}