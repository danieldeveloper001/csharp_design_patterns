using System;

namespace Project
{
    public class DefendMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player) =>
            player.Defend();

        protected override string MenuOptionLabel() => "Defend";
    }
}