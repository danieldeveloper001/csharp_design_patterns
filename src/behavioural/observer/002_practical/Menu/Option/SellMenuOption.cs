using System;

namespace Project
{
    public class SellMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            var sold = player.Sell(Settings.ARTIFACT_NAME, Settings.ARTIFACT_PRICE);
            if (!sold)
                return;

            Console.WriteLine($"\n{Settings.ARTIFACT_NAME} sold! {Settings.ARTIFACT_PRICE} moneys added to wallet!");
            Console.WriteLine($"{player.Money} moneys in wallet!");
        }

        protected override string MenuOptionLabel() => "Sell";
    }
}