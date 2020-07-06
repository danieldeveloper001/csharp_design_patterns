using System;

namespace Project
{
    public class WeaponPowerUpFactory : IPowerUpFactory
    {
        public IPowerUp Create(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new WeaponPowerUp(bonus: 100);
                case Level.Medium:
                    return new WeaponPowerUp(bonus: 50);
                case Level.Hard:
                    return new WeaponPowerUp(bonus: 25);
                default:
                    return null;
            }
        }
    }
}