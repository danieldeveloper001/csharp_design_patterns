using System;

namespace Project
{
    public class SellMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            var sold = player.Sell(Program.ARTIFACT_NAME, Program.ARTIFACT_PRICE);
            if (!sold)
                return;

            Console.WriteLine($"\n{Program.ARTIFACT_NAME} sold! {Program.ARTIFACT_PRICE} moneys added to wallet!");
            Console.WriteLine($"{player.Money} moneys in wallet!");
        }

        protected override string MenuOptionLabel() => "Sell";
    }
}