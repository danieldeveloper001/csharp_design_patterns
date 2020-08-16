using System;

namespace Project
{
    public class LightPlayer : IPlayer
    {
        private IAttackItem _attackItem;
        private IDefenseItem _defenseItem;

        public LightPlayer(IAttackItem attackItem, IDefenseItem defenseItem)
        {
            _attackItem = attackItem;
            _defenseItem = defenseItem;
        }

        public void Display()
        {
            Console.WriteLine($"{nameof(LightPlayer)} has been created and equipped, prepare for an easy game!");
            Console.WriteLine($"Attack: {_attackItem.GetType().Name}");
            Console.WriteLine($"Defense: {_defenseItem.GetType().Name}");
        }
    }
}