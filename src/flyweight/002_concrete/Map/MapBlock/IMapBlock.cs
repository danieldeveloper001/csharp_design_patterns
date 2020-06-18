using System;

namespace Project
{
    public interface IMapBlock
    {
        string Description { get; }

        void Draw(int x, int y);
    }
}