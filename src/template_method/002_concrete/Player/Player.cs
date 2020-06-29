using System;

namespace Project
{
    public abstract class Player
    {
        public int Life { get; private set; }
        public bool IsAlive { get => Life > 0; }

        public Player()
        {
            Life = 100;
        }


        public int Attack(Player player)
        {
            Console.WriteLine(OnAttackMessage());

            var expectedDamage = GetAttackPower();
            if (expectedDamage == 0)
                return expectedDamage;

            var actualDamage = player.Defend(expectedDamage);

            return actualDamage;
        }

        public int Defend(int expectedDamage)
        {
            var actualDamage = GetDefendPower(expectedDamage);
            this.Life -= actualDamage;

            return actualDamage;
        }

        protected abstract int GetAttackPower();
        protected abstract int GetDefendPower(int expectedDamage);

        protected abstract string OnAttackMessage();
    }
}