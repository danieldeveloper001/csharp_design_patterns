using System;

namespace Project
{
    public class Saver : IAchievement
    {
        public bool IsAchieved { get; private set; }

        public void Update(IPlayer player)
        {
            if (IsAchieved)
                return;

            if (player.Money < 100)
                return;

            Console.WriteLine($"\n[{nameof(Saver)}] achievement unlocked!");
            IsAchieved = true;
        }
    }
}