using System;

namespace Project
{
    public class ShieldPowerUpFactory : IPowerUpFactory
    {
        public IPowerUp Create(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new ShieldPowerUp(bonus: 15);
                case Level.Medium:
                    return new ShieldPowerUp(bonus: 10);
                case Level.Hard:
                    return new ShieldPowerUp(bonus: 5);
                default:
                    return null;
            }
        }
    }
}