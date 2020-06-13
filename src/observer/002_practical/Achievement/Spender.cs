using System;

namespace Project
{
    public class Spender : IAchievement
    {
        public bool IsAchieved { get; private set; }

        public void Update(IPlayer player)
        {
            if (IsAchieved)
                return;

            if (player.Money > 0)
                return;

            Console.WriteLine($"\n[{nameof(Spender)}] achievement unlocked!");
            IsAchieved = true;
        }
    }
}