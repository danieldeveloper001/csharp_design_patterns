using System;

namespace Project
{
    public interface IPlayer
    {
        IPlayerClass Class { get; }
        int Experience { get; }

        void Attack();
        void Defend();
    }
}