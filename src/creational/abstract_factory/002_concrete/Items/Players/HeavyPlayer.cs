using System;

namespace Project
{
    public class HeavyPlayer : IPlayer
    {
        private IAttackItem _attackItem;
        private IDefenseItem _defenseItem;

        public HeavyPlayer(IAttackItem attackItem, IDefenseItem defenseItem)
        {
            _attackItem = attackItem;
            _defenseItem = defenseItem;
        }

        public void Display()
        {
            Console.WriteLine($"{nameof(HeavyPlayer)} has been created and equipped, prepare for a hard game!");
            Console.WriteLine($"Attack: {_attackItem.GetType().Name}");
            Console.WriteLine($"Defense: {_defenseItem.GetType().Name}");
        }
    }
}