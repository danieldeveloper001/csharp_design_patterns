using System;
using System.Linq;

namespace Project
{
    public class WeaponPowerUp : IPowerUp
    {
        public int Bonus { get; private set; }

        public WeaponPowerUp(int bonus)
            => Bonus = bonus;

        public void ApplyTo(IShip ship)
            => ship.Reload(Bonus);

    }
}