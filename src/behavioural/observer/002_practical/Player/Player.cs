using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Player : IPlayer
    {
        public IList<Achievement> Achievements { get; private set; }
        public int Distance { get; private set; }
        public int Experience { get; private set; }
        public IList<string> Inventory { get; private set; }
        public int Money { get; private set; }

        public Player()
        {
            Achievements = new List<Achievement>()
            {
                new Killer(),
                new Saver(),
                new Spender(),
                new Traveler()
            };
            Inventory = new List<string>();

            Distance = 0;
            Experience = 0;
            Money = 50;
        }

        public void Walk(int distance)
        {
            Distance += distance;
            ProcessAchievements();
        }

        public bool Buy(string artifact, int price)
        {
            if (Money <= 0)
                return false;

            Money -= price;
            Inventory.Add(artifact);
            ProcessAchievements();

            return true;
        }

        public void Kill(string monster, int level)
        {
            Experience += level;
            Money += level;

            ProcessAchievements();
        }

        public bool Sell(string artifact, int price)
        {
            var artifactToRemove = Inventory.FirstOrDefault(x => x == artifact);
            if (String.IsNullOrWhiteSpace(artifactToRemove))
                return false;

            Money += price;
            Inventory.Remove(artifactToRemove);
            ProcessAchievements();

            return true;
        }

        private void ProcessAchievements()
        {
            foreach(var achievement in Achievements)
                achievement.Update(this);
        }
    }
}
