using System;

namespace Project
{
    public class LifePowerUpFactory : IPowerUpFactory
    {
        public IPowerUp Create(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new LifePowerUp(bonus: 50);
                case Level.Medium:
                    return new LifePowerUp(bonus: 25);
                case Level.Hard:
                    return new LifePowerUp(bonus: 5);
                default:
                    return null;
            }
        }
    }
}