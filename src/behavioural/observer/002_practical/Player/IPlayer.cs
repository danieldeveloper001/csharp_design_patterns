using System;
using System.Collections.Generic;

namespace Project
{
    public interface IPlayer
    {
        IList<Achievement> Achievements { get; }
        int Distance { get; }
        int Experience { get; }
        IList<string> Inventory { get; }
        int Money { get; }

        bool Buy(string artifact, int price);
        void Kill(string monster, int level);
        bool Sell(string artifact, int price);
        void Walk(int distance);
    }
}