using System;

namespace Project
{
    public class KillMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            player.Kill(Program.MONSTER_NAME, Program.MONSTER_LEVEL);
            Console.WriteLine($"\n{Program.MONSTER_NAME} killed! {Program.MONSTER_LEVEL} experiences gained!");
            Console.WriteLine($"{player.Experience} experiences gained in total!");
        }

        protected override string MenuOptionLabel() => "Kill";
    }
}