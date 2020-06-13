using System;

namespace Project
{
    public class Killer : IAchievement
    {
        public bool IsAchieved { get; private set; }

        public void Update(IPlayer player)
        {
            if (IsAchieved)
                return;

            if (player.Experience < 100)
                return;

            Console.WriteLine($"\n[{nameof(Killer)}] achievement unlocked!");
            IsAchieved = true;
        }
    }
}