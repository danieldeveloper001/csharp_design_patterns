using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public interface IShip
    {
        string Name { get; }
        int Life { get; }
        int Shield { get; }
        int Speed { get; }
        int Weapon { get; }

        void Accelerate(int amount);
        void Damage(int amount);
        void Defend(int amount);
        void Heal(int amount);
        void Reload(int amount);
        int Shoot(int amount);
    }
}