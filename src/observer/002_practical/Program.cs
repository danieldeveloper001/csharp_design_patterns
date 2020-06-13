using System;
using System.Linq;

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
                Console.Clear();
                Console.WriteLine("\n>>> ADVENTURER <<<\n");

                Console.WriteLine("1 - Walk");
                Console.WriteLine("2 - Buy Artifact");
                Console.WriteLine("3 - Sell Artifact");
                Console.WriteLine("4 - Kill Monster");
                Console.WriteLine("5 - Inventory");
                Console.WriteLine("6 - Achievements");
                Console.WriteLine("0 - Exit");

                Console.Write("\nWhat would you like to do? ");
                action = Console.ReadKey();

                Console.WriteLine();

                switch(action.KeyChar)
                {
                    case '1':
                        player.Walk(WALK_DISTANCE);
                        Console.WriteLine($"\n{WALK_DISTANCE} distances walked!");
                        Console.WriteLine($"{player.Distance} distances walked in total!");
                        break;
                    case '2':
                        var bought = player.Buy(ARTIFACT_NAME, ARTIFACT_PRICE);
                        if (!bought)
                            continue;

                        Console.WriteLine($"\n{ARTIFACT_NAME} bought! {ARTIFACT_PRICE} moneys removed from wallet!");
                        Console.WriteLine($"{player.Money} moneys in wallet!");
                        break;
                    case '3':
                        var sold = player.Sell(ARTIFACT_NAME, ARTIFACT_PRICE);
                        if (!sold)
                            continue;

                        Console.WriteLine($"\n{ARTIFACT_NAME} sold! {ARTIFACT_PRICE} moneys added to wallet!");
                        Console.WriteLine($"{player.Money} moneys in wallet!");
                        break;
                    case '4':
                        player.Kill(MONSTER_NAME, MONSTER_LEVEL);
                        Console.WriteLine($"\n{MONSTER_NAME} killed! {MONSTER_LEVEL} experiences gained!");
                        Console.WriteLine($"{player.Experience} experiences gained in total!");
                        break;
                    case '5':
                        Console.WriteLine("\n>>> Inventory");
                        foreach(var item in player.Inventory)
                            Console.WriteLine($"- {item}");

                        break;
                    case '6':
                        Console.WriteLine("\n>>> Achievements");
                        var achievements = player.Achievements.Where(x => x.IsAchieved);
                        foreach(var achievement in achievements)
                            Console.WriteLine($"- {achievement.GetType().Name}");

                        break;
                    default:
                        break;
                }

                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            } while (action.KeyChar != '0') ;

            Console.WriteLine();
        }
    }
}
