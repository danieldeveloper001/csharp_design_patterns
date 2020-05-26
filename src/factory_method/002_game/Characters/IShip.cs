using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public interface IShip
    {
        IList<IPowerUp> PowerUps { get; }
        string Name { get; }
        int Life { get; }
        int Shield { get; }
        int Speed { get; }
        int Weapon { get; }

        void PowerUp(IPowerUp powerUp);
        void Damage(int amount);
        int Shoot(int amount);
    }
}