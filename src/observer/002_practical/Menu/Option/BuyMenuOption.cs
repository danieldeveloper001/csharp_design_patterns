using System;

namespace Project
{
    public class BuyMenuOption : MenuOption
    {
        protected override void MenuOptionAction(IPlayer player)
        {
            var bought = player.Buy(Program.ARTIFACT_NAME, Program.ARTIFACT_PRICE);
            if (!bought)
                return;

            Console.WriteLine($"\n{Program.ARTIFACT_NAME} bought! {Program.ARTIFACT_PRICE} moneys removed from wallet!");
            Console.WriteLine($"{player.Money} moneys in wallet!");
        }

        protected override string MenuOptionLabel() => "Buy";
    }
}