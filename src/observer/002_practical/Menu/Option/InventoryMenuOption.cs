using System;
using System.Linq;

namespace Project
{
    public class InventoryMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            Console.WriteLine("\n>>> Inventory");
            if (player.Inventory.Count == 0)
            {
                Console.WriteLine("No artifacts yet!");
                return;
            }

            foreach(var item in player.Inventory)
                Console.WriteLine($"- {item}");
        }

        protected override string MenuOptionLabel() => "Inventory";
    }
}