using System;

namespace Project
{
    public class WalkMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            player.Walk(Settings.WALK_DISTANCE);
            Console.WriteLine($"\n{Settings.WALK_DISTANCE} distances walked!");
            Console.WriteLine($"{player.Distance} distances walked in total!");
        }

        protected override string MenuOptionLabel() => "Walk";
    }
}