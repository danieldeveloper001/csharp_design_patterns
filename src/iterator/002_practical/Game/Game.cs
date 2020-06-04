using System;

namespace Project
{
    public class Game : IGame
    {
        public string Name { get; private set; }
        public string Genre { get; private set; }
        public bool HasLocalMultiplayer { get; private set; }
        public bool HasRemoteMultiplayer { get; private set; }

        public Game(
            string name,
            string genre,
            bool hasLocalMultiplayer,
            bool hasRemoteMultiplayer)
        {
            Name = name;
            Genre = genre;
            HasLocalMultiplayer = hasLocalMultiplayer;
            HasRemoteMultiplayer = hasRemoteMultiplayer;
        }
    }
}