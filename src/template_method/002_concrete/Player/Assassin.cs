using System;

namespace Project
{
    public class Assassin : Player
    {
        public static int MAX_ATTACK = 5;
        public static int MAX_DEFENSE = 3;

        public static string[] ATTACK_MESSAGES =
        {
            "feel the taste of my sword!",
            "fear my red eyes and sword that cuts the evil!",
            "eliminate!"
        };

        protected override int GetAttackPower()
        {
            var multiplier = Life >= 75 ? 2 : 1;
            return new Random().Next(MAX_ATTACK) * multiplier;
        }

        protected override int GetDefendPower(int expectedDamage)
        {
            if (expectedDamage >= MAX_DEFENSE)
                return MAX_DEFENSE;

            return new Random().Next(MAX_DEFENSE - expectedDamage);
        }

        protected override string OnAttackMessage() =>
            ATTACK_MESSAGES[new Random().Next(ATTACK_MESSAGES.Length)];
    }
}