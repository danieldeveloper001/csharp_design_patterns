using System;

namespace Project
{
    public class BoardSnapshot
    {
        public char[,] Positions { get; private set; }

        public BoardSnapshot(char[,] positions)
        {
            Positions = new char[3,3];
            Array.Copy(positions, Positions, positions.Length);
        }
    }
}