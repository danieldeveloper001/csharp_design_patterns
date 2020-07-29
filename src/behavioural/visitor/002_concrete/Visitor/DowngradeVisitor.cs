using System;

namespace Project
{
    public class DowngradeVisitor : IVisitor
    {
        public void Visit(Potion item)
        {
            Console.WriteLine($"\n{nameof(Potion)} suffered a downgrade!");
            item.Magic -= 5;
        }

        public void Visit(Shield item)
        {
            Console.WriteLine($"\n{nameof(Shield)} suffered a downgrade!");
            item.Defense -= 5;
            item.Speed -= 3;
        }

        public void Visit(Sword item)
        {
            Console.WriteLine($"\n{nameof(Sword)} suffered a downgrade!");
            item.Attack -= 5;
            item.Speed -= 3;
        }
    }
}