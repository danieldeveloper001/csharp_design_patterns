using System;
using System.Linq;

namespace Project
{
    public class AchievementsMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            //TODO: MOVE THIS LOGIC
            Console.WriteLine("\n>>> Achievements");
            var achievements = player.Achievements
                .Where(x => x.IsAchieved)
                .ToList();

            if (achievements.Count == 0)
            {
                Console.WriteLine("No achievements yet!");
                return;
            }

            foreach(var achievement in achievements)
                Console.WriteLine($"- {achievement.GetType().Name}");
        }

        protected override string MenuOptionLabel() => "Achievements";
    }
}