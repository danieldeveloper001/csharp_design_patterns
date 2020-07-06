using System;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(">>> ALLEY FIGHTERS <<<");

            var player1 = new Ninja();
            var player2 = new Assassin();

            int round = 1;
            do
            {
                Console.WriteLine($"\n> Round #{round}");
                Console.WriteLine($"Player 1: {player1.Life} life.");
                Console.WriteLine($"Player 2: {player2.Life} life.");

                player1.Attack(player2);
                player2.Attack(player1);

                round++;
            } while (player1.IsAlive && player2.IsAlive);
        }
    }
}
