using System;

namespace Project
{
    public class Traveler : Achievement
    {
        protected override bool IsAchievedBy(IPlayer player) =>
            player.Distance >= 100;
    }
}