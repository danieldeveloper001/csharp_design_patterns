using System;

namespace Project
{
    public interface IGame
    {
        string Name { get; }
        string Genre { get; }
        bool HasLocalMultiplayer { get; }
        bool HasRemoteMultiplayer { get; }
    }
}