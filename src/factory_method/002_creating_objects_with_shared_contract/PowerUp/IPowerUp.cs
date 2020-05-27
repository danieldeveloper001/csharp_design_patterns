using System;
using System.Collections.Generic;

namespace Project
{
    public interface IPowerUp
    {
        int Bonus { get; }

        void ApplyTo(IShip ship);
    }
}