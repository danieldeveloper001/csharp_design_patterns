using System;
using System.Linq;
using System.Collections.Generic;

namespace Project
{
    interface IGameTurn
    {
        IList<IGameAction> Actions { get; }

        void Add(IGameAction action);
        void Execute();
    }

    class GameTurn : IGameTurn
    {
        public IList<IGameAction> Actions { get; private set; }

        public GameTurn()
        {
            Actions = new List<IGameAction>();
        }

        public void Add(IGameAction action) =>
            Actions.Add(action);

        public void Execute() =>
            Actions
                .ToList()
                .ForEach(action => action.Execute());
    }
}
