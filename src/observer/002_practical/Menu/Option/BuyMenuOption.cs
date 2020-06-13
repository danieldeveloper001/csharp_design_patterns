using System;

namespace Project
{
    public class BuyMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            var bought = player.Buy(Settings.ARTIFACT_NAME, Settings.ARTIFACT_PRICE);
            if (!bought)
                return;

            Console.WriteLine($"\n{Settings.ARTIFACT_NAME} bought! {Settings.ARTIFACT_PRICE} moneys removed from wallet!");
            Console.WriteLine($"{player.Money} moneys in wallet!");
        }

        protected override string MenuOptionLabel() => "Buy";
    }
}