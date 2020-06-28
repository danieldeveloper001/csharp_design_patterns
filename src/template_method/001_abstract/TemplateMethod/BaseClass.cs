using System;

namespace Project
{
    public abstract class BaseClass
    {
        public void Operation()
        {
            Console.WriteLine($"\n{nameof(BaseClass)}.{nameof(Operation)} executing...");
            if (Condition())
            {
                OnTrueCondition();
                return;
            }

            OnFalseCondition();
        }

        protected abstract bool Condition();
        protected abstract void OnTrueCondition();
        protected abstract void OnFalseCondition();
    }
}