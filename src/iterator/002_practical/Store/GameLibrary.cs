using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project
{
    public interface IGameLibrary
    {
        IEnumerable<Game> Find(Func<Game, bool> expression);

        IGameLibraryIterator SinglePlayerGamesIterator();
        IGameLibraryIterator LocalMultiplayerGamesIterator();
        IGameLibraryIterator RemoteMultiplayerGamesIterator();
    }
    public class GameLibrary : IGameLibrary
    {
        private IEnumerable<Game> _games;

        public GameLibrary()
        {
            _games = new List<Game>()
            {
                new Game("Arcade Game 1", "Arcade", hasLocalMultiplayer: false, hasRemoteMultiplayer: false),
                new Game("Arcade Game 2", "Arcade", hasLocalMultiplayer: true, hasRemoteMultiplayer: false),
                new Game("Arcade Game 3", "Arcade", hasLocalMultiplayer: true, hasRemoteMultiplayer: true),
                new Game("Fighting Game 1", "Fighting", hasLocalMultiplayer: false, hasRemoteMultiplayer: false),
                new Game("Fighting Game 2", "Fighting", hasLocalMultiplayer: true, hasRemoteMultiplayer: false),
                new Game("Fighting Game 3", "Fighting", hasLocalMultiplayer: true, hasRemoteMultiplayer: true),
                new Game("Racing Game 1", "Racing", hasLocalMultiplayer: false, hasRemoteMultiplayer: false),
                new Game("Racing Game 2", "Racing", hasLocalMultiplayer: true, hasRemoteMultiplayer: false),
                new Game("Racing Game 3", "Racing", hasLocalMultiplayer: true, hasRemoteMultiplayer: true)
            };
        }

        public IEnumerable<Game> Find(Func<Game, bool> expression) =>
            _games.Where(expression);

        public IGameLibraryIterator SinglePlayerGamesIterator() =>
            new SinglePlayerGamesIterator(this);
        public IGameLibraryIterator LocalMultiplayerGamesIterator() =>
            new LocalMultiplayerIterator(this);

        public IGameLibraryIterator RemoteMultiplayerGamesIterator() =>
            new RemoteMultiplayerIterator(this);
    }
}