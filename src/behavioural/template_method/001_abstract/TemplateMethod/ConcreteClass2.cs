using System;

namespace Project
{
    public class ConcreteClass2 : BaseClass
    {
        protected override bool Condition()
        {
            Console.WriteLine($"{nameof(ConcreteClass2)}.{nameof(Condition)} executing...");
            return false;
        }

        protected override void OnTrueCondition()
        {
            Console.WriteLine($"{nameof(ConcreteClass2)}.{nameof(OnTrueCondition)} executed!");
        }

        protected override void OnFalseCondition()
        {
            Console.WriteLine($"{nameof(ConcreteClass2)}.{nameof(OnFalseCondition)} executed!");
        }
    }
}