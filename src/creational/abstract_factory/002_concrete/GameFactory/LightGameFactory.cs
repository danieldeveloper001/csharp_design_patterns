using System;

namespace Project
{
    public class LightGameFactory : IGameFactory
    {
        public IAttackItem CreateAttackItem() =>
            new LightWeapon();

        public IDefenseItem CreateDefenseItem() =>
            new LightShield();

        public IPlayer CreatePlayer(IAttackItem attackItem, IDefenseItem defenseItem) =>
            new LightPlayer(attackItem, defenseItem);
    }
}