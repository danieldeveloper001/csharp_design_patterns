using System;

namespace Project
{
    public class Killer : Achievement
    {
        protected override bool IsAchievedBy(IPlayer player) =>
            player.Experience >= 100;
    }
}