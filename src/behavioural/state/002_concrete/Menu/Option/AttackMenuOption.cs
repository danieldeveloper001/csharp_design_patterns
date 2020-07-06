using System;

namespace Project
{
    public class AttackMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player) =>
            player.Attack();

        protected override string MenuOptionLabel() => "Attack";
    }
}