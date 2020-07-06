using System;
using System.Collections.Generic;

namespace Project
{
    public class BoardHistory
    {
        public Stack<BoardSnapshot> Snapshots { get; private set; }

        public BoardHistory()
        {
            Snapshots = new Stack<BoardSnapshot>();
        }

        public void Do(BoardSnapshot snapshot)
        {
            Snapshots.Push(snapshot);
        }

        public BoardSnapshot Undo()
        {
            if (Snapshots.Count == 0)
                return null;

            return Snapshots.Pop();
        }
    }
}