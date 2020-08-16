using System;

namespace Project
{
    public interface IGameFactory
    {
        IAttackItem CreateAttackItem();
        IDefenseItem CreateDefenseItem();
        IPlayer CreatePlayer(IAttackItem attackItem, IDefenseItem defenseItem);
    }
}