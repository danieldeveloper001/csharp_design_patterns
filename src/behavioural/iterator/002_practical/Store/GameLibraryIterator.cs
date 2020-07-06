using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public interface IGameLibraryIterator
    {
        bool HasNext();
        IGame Next();
    }

    public abstract class GameLibraryIterator : IGameLibraryIterator
    {
        protected IEnumerable<Game> _games;
        protected int _current;

        public bool HasNext() =>
            _current < _games.Count();

        public IGame Next() =>
            _games.ElementAt(_current++);
    }

    public class SinglePlayerGamesIterator : GameLibraryIterator
    {
        public SinglePlayerGamesIterator(IGameLibrary library)
        {
            _games = library.Find(x => !x.HasLocalMultiplayer && !x.HasRemoteMultiplayer);
            _current = 0;
        }
    }

    public class LocalMultiplayerIterator : GameLibraryIterator
    {
        public LocalMultiplayerIterator(IGameLibrary library)
        {
            _games = library.Find(x => x.HasLocalMultiplayer);
            _current = 0;
        }
    }

    public class RemoteMultiplayerIterator : GameLibraryIterator
    {
        public RemoteMultiplayerIterator(IGameLibrary library)
        {
            _games = library.Find(x => x.HasRemoteMultiplayer);
            _current = 0;
        }
    }
}