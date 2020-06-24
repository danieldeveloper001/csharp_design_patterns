using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            var menu = new Menu();
            menu.AddOption(new AttackMenuOption());
            menu.AddOption(new DefendMenuOption());
            menu.AddOption(new ExitMenuOption());

            do
            {
                menu.Display();
                var option = menu.ReadOption();
                menu.Execute(option, player);
                menu.Wait();
            } while (true);
        }
    }
}
