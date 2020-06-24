using System;

namespace Project
{
    public class LowRank : IPlayerClass
    {
        public int AttackStrenght { get; private set; }
        public int DefenseStrenght { get; private set; }

        public LowRank()
        {
            AttackStrenght = 10;
            DefenseStrenght = 5;
        }

        public int Attack()
        {
            Console.WriteLine($"{nameof(LowRank)} player attacked with strength '{AttackStrenght}'!");
            return AttackStrenght;
        }

        public int Defend()
        {
            Console.WriteLine($"{nameof(LowRank)} player defended with strength '{DefenseStrenght}'!");
            return DefenseStrenght;
        }

        public IPlayerClass GetClassFor(IPlayer player)
        {
            if (player.Experience >= 50)
            {
                Console.WriteLine($"{nameof(LowRank)} player promoted to {nameof(MidRank)}!");
                return new MidRank();
            }

            return this;
        }
    }
}