using System;

namespace Project
{
    public class SpeedPowerUpFactory : IPowerUpFactory
    {
        public IPowerUp Create(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new SpeedPowerUp(bonus: 15);
                case Level.Medium:
                    return new SpeedPowerUp(bonus: 10);
                case Level.Hard:
                    return new SpeedPowerUp(bonus: 5);
                default:
                    return null;
            }
        }
    }
}