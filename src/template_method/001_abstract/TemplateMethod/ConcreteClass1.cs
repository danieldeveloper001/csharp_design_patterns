using System;

namespace Project
{
    public class ConcreteClass1 : BaseClass
    {
        protected override bool Condition()
        {
            Console.WriteLine($"{nameof(ConcreteClass1)}.{nameof(Condition)} executing...");
            return true;
        }

        protected override void OnTrueCondition()
        {
            Console.WriteLine($"{nameof(ConcreteClass1)}.{nameof(OnTrueCondition)} executed!");
        }

        protected override void OnFalseCondition()
        {
            Console.WriteLine($"{nameof(ConcreteClass1)}.{nameof(OnFalseCondition)} executed!");
        }

    }
}