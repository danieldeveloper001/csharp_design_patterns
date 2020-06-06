using System;

namespace Project
{
    class Program
    {
        static void DisplayGameLibraryBy(IGameLibraryIterator iterator)
        {
            Console.WriteLine($"\n>>> Game Library ({iterator.GetType().Name})");
            while(iterator.HasNext())
            {
                var game = iterator.Next();
                Console.WriteLine($"- [{game.Genre}] {game.Name}");
            }
        }

        static void Main(string[] args)
        {
            var library = new GameLibrary();

            DisplayGameLibraryBy(library.SinglePlayerGamesIterator());
            DisplayGameLibraryBy(library.LocalMultiplayerGamesIterator());
            DisplayGameLibraryBy(library.RemoteMultiplayerGamesIterator());
        }
    }
}
