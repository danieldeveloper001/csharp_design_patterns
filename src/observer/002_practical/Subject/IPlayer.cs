using System;
using System.Collections.Generic;

namespace Project
{
    public interface IPlayer
    {
        IList<IAchievement> Achievements { get; }
        IList<string> Artifacts { get; }
        int Distance { get; }
        int Experience { get; }
        int Money { get; }

        void Buy(string artifact, int price);
        void Kill(string monster, int level);
        void Sell(string artifact, int price);
        void Walk(int distance);
    }
}