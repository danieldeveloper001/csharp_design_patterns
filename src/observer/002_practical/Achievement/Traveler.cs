using System;

namespace Project
{
    public class Traveler : IAchievement
    {
        public bool IsAchieved { get; private set; }

        public void Update(IPlayer player)
        {
            if (IsAchieved)
                return;

            if (player.Distance < 100)
                return;

            Console.WriteLine($"\n[{nameof(Traveler)}] achievement unlocked!");
            IsAchieved = true;
        }
    }
}