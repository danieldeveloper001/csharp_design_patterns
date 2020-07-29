using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerItems = new List<IItem>()
            {
                new Potion(10),
                new Shield(10, 10),
                new Sword(10, 10)
            };

            var displayer = new DisplayVisitor();
            var upgrader = new UpgradeVisitor();
            var downgrader = new DowngradeVisitor();

            // Player progresses through the game
            playerItems.ForEach(x => x.Accept(upgrader));
            playerItems.ForEach(x => x.Accept(displayer));

            playerItems.ForEach(x => x.Accept(upgrader));
            playerItems.ForEach(x => x.Accept(displayer));

            playerItems.ForEach(x => x.Accept(upgrader));
            playerItems.ForEach(x => x.Accept(displayer));

            // Player dies
            playerItems.ForEach(x => x.Accept(downgrader));
            playerItems.ForEach(x => x.Accept(displayer));
        }
    }
}
