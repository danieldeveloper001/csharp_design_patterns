using System;

namespace Project
{
    class Program
    {
        const String ARTIFACT_NAME = "ARTIFACT";
        const int ARTIFACT_PRICE = 25;
        const String MONSTER_NAME = "MONSTER";
        const int MONSTER_LEVEL = 5;
        const int WALK_DISTANCE = 10;

        static void Main(string[] args)
        {
            var player = new Player();

            ConsoleKeyInfo action;
            do
            {
                Console.WriteLine("\n>>> ADVENTURER <<<\n");

                Console.WriteLine("1 - Walk");
                Console.WriteLine("2 - Buy Artifact");
                Console.WriteLine("3 - Sell Artifact");
                Console.WriteLine("4 - Kill Monster");
                Console.WriteLine("0 - Exit");

                Console.Write("\nWhat would you like to do? ");
                action = Console.ReadKey();

                Console.Clear();
                switch(action.KeyChar)
                {
                    case '1':
                        player.Walk(WALK_DISTANCE);
                        break;
                    case '2':
                        player.Buy(ARTIFACT_NAME, ARTIFACT_PRICE);
                        break;
                    case '3':
                        player.Sell(ARTIFACT_NAME, ARTIFACT_PRICE);
                        break;
                    case '4':
                        player.Kill(MONSTER_NAME, MONSTER_LEVEL);
                        break;
                    default:
                        break;
                }

            } while (action.KeyChar != '0') ;

            Console.WriteLine();
        }
    }
}
