using System;
using System.Linq;

namespace Project
{
    public class Program
    {
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

            do
            {
                menu.Display();
                var option = menu.ReadOption();
                menu.Execute(option, player);
                menu.Wait();
            } while (true);
        }
    }
}

