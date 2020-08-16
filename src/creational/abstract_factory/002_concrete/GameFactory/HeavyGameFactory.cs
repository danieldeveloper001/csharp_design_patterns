using System;

namespace Project
{
    public class HeavyGameFactory : IGameFactory
    {
        public IAttackItem CreateAttackItem() =>
            new HeavyWeapon();

        public IDefenseItem CreateDefenseItem() =>
            new HeavyShield();

        public IPlayer CreatePlayer(IAttackItem attackItem, IDefenseItem defenseItem) =>
            new HeavyPlayer(attackItem, defenseItem);
    }
}