using System;

namespace Project
{
    public abstract class Achievement
    {
        public bool IsAchieved { get; private set; }

        public void Update(IPlayer player)
        {
            if (IsAchieved)
                return;

            IsAchieved = IsAchievedBy(player);
        }

        protected abstract bool IsAchievedBy(IPlayer player);

    }
}