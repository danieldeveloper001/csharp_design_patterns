using System;
using System.Linq;

namespace Project
{
    public class ExitMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            Console.WriteLine();
            Environment.Exit(0);
        }

        protected override string MenuOptionLabel() => "Exit";
    }
}