using System;
using System.Collections.Generic;

namespace Project
{
    interface ITransaction
    {
        IList<IOperation> ExecutedOperations { get; }

        bool Execute(IOperation operation);
        void Report();
    }

    class Transaction : ITransaction
    {
        public IList<IOperation> ExecutedOperations { get; private set; }

        public Transaction()
        {
            ExecutedOperations = new List<IOperation>();
        }

        public bool Execute(IOperation operation)
        {
            Console.WriteLine($"[INFORMATION] Executing '{operation.GetType().Name} of '{operation.Amount}'...");
            bool executed = operation.Execute();
            if (!executed)
                return false;

            ExecutedOperations.Add(operation);
            return true;
        }

        public void Report()
        {
            Console.WriteLine();
            Console.WriteLine($"> Transaction Report");
            foreach(var executedOperation in ExecutedOperations)
                Console.WriteLine($"{executedOperation.GetType().Name, -30}{executedOperation.Amount, 10}");
        }
    }
}
