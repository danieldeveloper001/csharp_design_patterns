using System;

namespace Project
{
    public class DisplayVisitor : IVisitor
    {
        public void Visit(Potion item)
        {
            Console.WriteLine($"\n{nameof(Potion)}");
            Console.WriteLine($"- {item.Magic} points of {nameof(Potion.Magic)}");

        }

        public void Visit(Shield item)
        {
            Console.WriteLine($"\n{nameof(Shield)}");
            Console.WriteLine($"- {item.Defense} points of {nameof(Shield.Defense)}");
            Console.WriteLine($"- {item.Speed} points of {nameof(Shield.Speed)}");
        }

        public void Visit(Sword item)
        {
            Console.WriteLine($"\n{nameof(Sword)}");
            Console.WriteLine($"- {item.Attack} points of {nameof(Sword.Attack)}");
            Console.WriteLine($"- {item.Speed} points of {nameof(Sword.Speed)}");
        }
    }
}