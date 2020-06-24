using System;

namespace Project
{
    public class Player : IPlayer
    {
        public IPlayerClass Class { get; private set; }
        public int Experience { get; private set; }

        public Player()
        {
            Class = new LowRank();
        }

        public void Attack()
        {
            var points = Class.Attack();
            HandleExperienceChange(points);
        }

        public void Defend()
        {
            var points = Class.Defend();
            HandleExperienceChange(-points);
        }

        private void HandleExperienceChange(int points)
        {
            Experience += points;
            Console.WriteLine($"{points} experience points issued!");
            Console.WriteLine($"Experience: {Experience}");

            Class = Class.GetClassFor(this);
        }
    }
}
