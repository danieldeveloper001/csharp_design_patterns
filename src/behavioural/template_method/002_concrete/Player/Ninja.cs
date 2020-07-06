using System;

namespace Project
{
    public class Ninja : Player
    {
        public static int MAX_ATTACK = 3;
        public static int MAX_DEFENSE = 5;

        public static string[] ATTACK_MESSAGES =
        {
            "feel the taste of my kunai!",
            "fear my will and kunai that protect the innocent!",
            "shadow clones!"
        };

        protected override int GetAttackPower()
        {
            var multiplier = Life <= 25 ? 2 : 1;
            return new Random().Next(MAX_ATTACK) * multiplier;
        }

        protected override int GetDefendPower(int expectedDamage)
        {
            return new Random().Next(MAX_DEFENSE);
        }

        protected override string OnAttackMessage() =>
            ATTACK_MESSAGES[new Random().Next(ATTACK_MESSAGES.Length)];
    }
}
