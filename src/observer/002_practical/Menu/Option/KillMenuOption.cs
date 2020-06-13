using System;

namespace Project
{
    public class KillMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            player.Kill(Settings.MONSTER_NAME, Settings.MONSTER_LEVEL);
            Console.WriteLine($"\n{Settings.MONSTER_NAME} killed! {Settings.MONSTER_LEVEL} experiences gained!");
            Console.WriteLine($"{player.Experience} experiences gained in total!");
        }

        protected override string MenuOptionLabel() => "Kill";
    }
}