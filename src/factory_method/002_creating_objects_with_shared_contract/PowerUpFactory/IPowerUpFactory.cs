using System;

namespace Project
{
    public interface IPowerUpFactory
    {
        IPowerUp Create(Level level);
    }
}