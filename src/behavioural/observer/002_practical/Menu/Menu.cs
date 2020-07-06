using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Menu
    {
        private IList<MenuOption> _options;

        public Menu()
        {
            _options = new List<MenuOption>();
        }

        public void AddOption(MenuOption option)
        {
            option.Index = _options.Count + 1;

            if (_options.Count != 0)
                _options[_options.Count - 1].Next = option;

            _options.Add(option);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("\n>>> ADVENTURER <<<\n");

            _options.First().Display();
        }

        public void Execute(int option, IPlayer player)
        {
            _options.First().Execute(option, player);
        }

        public int ReadOption()
        {
            Console.Write("\nWhat would you like to do? ");
            var action = Console.ReadKey();

            return Convert.ToInt32(Char.GetNumericValue(action.KeyChar));
        }

        public void Wait()
        {
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
        }

    }
}
