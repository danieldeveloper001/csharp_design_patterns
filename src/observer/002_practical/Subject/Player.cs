using System;
using System.Collections.Generic;

namespace Project
{
    public class Player : IPlayer
    {
        public IList<IAchievement> Achievements { get; private set; }
        public IList<string> Artifacts { get; private set; }
        public int Distance { get; private set; }
        public int Experience { get; private set; }
        public int Money { get; private set; }

        public Player()
        {
            Achievements = new List<IAchievement>()
            {
                new Killer(),
                new Saver(),
                new Spender(),
                new Traveler()
            };

            Distance = 0;
            Experience = 0;
            Money = 50;
        }

        public void Walk(int distance)
        {
            Distance += distance;
            ProcessAchievements();
        }

        public void Buy(string artifact, int price)
        {
            Money -= price;
            ProcessAchievements();
        }

        public void Kill(string monster, int level)
        {
            Experience += level;
            ProcessAchievements();
        }

        public void Sell(string artifact, int price)
        {
            Money += price;
            ProcessAchievements();
        }

        private void ProcessAchievements()
        {
            foreach(var achievement in Achievements)
                achievement.Update(this);
        }
    }
}
