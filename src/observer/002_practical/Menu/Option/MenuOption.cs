using System;

namespace Project
{
    public abstract class MenuOption
    {
        public int Index { get; set; }
        public MenuOption Next { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Index} - {MenuOptionLabel()}");
            if (Next is null)
                return;

            Next.Display();
        }

        public void Execute(int index, IPlayer player)
        {
            if (Index == index)
            {
                MenuOptionAction(player);
            }
            else
            {
                if (Next is null)
                    return;

                Next.Execute(index, player);
            }
        }

        protected abstract void MenuOptionAction(IPlayer player);
        protected abstract string MenuOptionLabel();

    }
}