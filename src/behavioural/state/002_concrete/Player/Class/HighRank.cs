using System;

namespace Project
{
    public class HighRank : IPlayerClass
    {
        public int AttackStrenght { get; private set; }
        public int DefenseStrenght { get; private set; }

        public HighRank()
        {
            AttackStrenght = 30;
            DefenseStrenght = 15;
        }

        public int Attack()
        {
            Console.WriteLine($"{nameof(HighRank)} player attacked with strength '{AttackStrenght}'!");
            return AttackStrenght;
        }

        public int Defend()
        {
            Console.WriteLine($"{nameof(HighRank)} player defended with strength '{DefenseStrenght}'!");
            return DefenseStrenght;
        }

        public IPlayerClass GetClassFor(IPlayer player)
        {
            if (player.Experience < 100)
            {
                Console.WriteLine($"{nameof(HighRank)} player demoted to {nameof(MidRank)}!");
                return new MidRank();
            }

            return this;
        }
    }
}