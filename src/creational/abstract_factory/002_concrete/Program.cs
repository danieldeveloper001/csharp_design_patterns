using System;

namespace Project
{
    class Program
    {

        static void Play(IGameFactory factory)
        {
            var attackItem = factory.CreateAttackItem();
            var defenseItem = factory.CreateDefenseItem();
            var player = factory.CreatePlayer(attackItem, defenseItem);

            player.Display();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var lightGameFactory = new LightGameFactory();
            Play(lightGameFactory);

            var heavyGameFactory = new HeavyGameFactory();
            Play(heavyGameFactory);
        }
    }
}
