using System;
using System.Linq;

namespace Project
{
    public class Program
    {
        public static String ARTIFACT_NAME = "ARTIFACT";
        public static int ARTIFACT_PRICE = 25;
        public static String MONSTER_NAME = "MONSTER";
        public static int MONSTER_LEVEL = 5;
        public static int WALK_DISTANCE = 10;

        static void Main(string[] args)
        {
            var player = new Player();

            var menu = new Menu();
            menu.AddOption(new WalkMenuOption());
            menu.AddOption(new BuyMenuOption());
            menu.AddOption(new SellMenuOption());
            menu.AddOption(new KillMenuOption());
            menu.AddOption(new InventoryMenuOption());
            menu.AddOption(new AchievementsMenuOption());
            menu.AddOption(new ExitMenuOption());

            int option;
            do
            {
                menu.Display();
                option = menu.ReadAction();
                menu.Execute(option, player);
                menu.Wait();

            } while (true);
        }
    }
}

