using System;

namespace Project
{
    public class Spender : Achievement
    {
        protected override bool IsAchievedBy(IPlayer player) =>
            player.Money <= 0;
    }
}