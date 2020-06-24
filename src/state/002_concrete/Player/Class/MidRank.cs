using System;

namespace Project
{
    public class MidRank : IPlayerClass
    {
        public int AttackStrenght { get; private set; }
        public int DefenseStrenght { get; private set; }

        public MidRank()
        {
            AttackStrenght = 20;
            DefenseStrenght = 10;
        }

        public int Attack()
        {
            Console.WriteLine($"{nameof(MidRank)} player attacked with strength '{AttackStrenght}'!");
            return AttackStrenght;
        }

        public int Defend()
        {
            Console.WriteLine($"{nameof(MidRank)} player defended with strength '{DefenseStrenght}'!");
            return DefenseStrenght;
        }

        public IPlayerClass GetClassFor(IPlayer player)
        {
            if (player.Experience >= 100)
            {
                Console.WriteLine($"{nameof(MidRank)} player promoted to {nameof(HighRank)}!");
                return new HighRank();
            }

            if (player.Experience < 50)
            {
                Console.WriteLine($"{nameof(MidRank)} player demoted to {nameof(LowRank)}!");
                return new LowRank();
            }

            return this;
        }
    }
}