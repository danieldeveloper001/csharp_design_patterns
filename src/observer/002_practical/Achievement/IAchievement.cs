using System;

namespace Project
{
    public interface IAchievement
    {
        bool IsAchieved { get; }

        void Update(IPlayer player);
    }
}