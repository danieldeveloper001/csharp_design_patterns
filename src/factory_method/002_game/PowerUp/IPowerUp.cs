using System;
using System.Collections.Generic;

namespace Project
{
    public interface IPowerUp
    {
        int Bonus { get; }

        bool IsEquippable(IShip ship);
    }
}