using System;

namespace Project
{
    public interface IPlayerClass
    {
        int AttackStrenght { get; }
        int DefenseStrenght { get; }

        int Attack();
        int Defend();

        IPlayerClass GetClassFor(IPlayer player);

    }
}