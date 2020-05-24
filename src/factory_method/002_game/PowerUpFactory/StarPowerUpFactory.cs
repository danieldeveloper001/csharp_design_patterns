using System;

namespace Project
{
    public class StarPowerUpFactory : IPowerUpFactory
    {
        public IPowerUp Create(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new StarPowerUp(bonus: 100);
                case Level.Medium:
                    return new StarPowerUp(bonus: 50);
                case Level.Hard:
                    return new StarPowerUp(bonus: 25);
                default:
                    return null;
            }
        }
    }
}