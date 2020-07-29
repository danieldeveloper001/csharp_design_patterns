using System;

namespace Project
{
    public class UpgradeVisitor : IVisitor
    {
        public void Visit(Potion item)
        {
            Console.WriteLine($"\n{nameof(Potion)} received an upgrade!");
            item.Magic += 10;
        }

        public void Visit(Shield item)
        {
            Console.WriteLine($"\n{nameof(Shield)} received an upgrade!");
            item.Defense += 10;
            item.Speed += 5;
        }

        public void Visit(Sword item)
        {
            Console.WriteLine($"\n{nameof(Sword)} received an upgrade!");
            item.Attack += 10;
            item.Speed += 5;
        }
    }
}