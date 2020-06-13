using System;

namespace Project
{
    public class Saver : Achievement
    {
        protected override bool IsAchievedBy(IPlayer player) =>
            player.Money >= 100;
    }
}