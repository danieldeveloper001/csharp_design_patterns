using System;
using System.Collections.Generic;

namespace Project
{
    interface ITransaction
    {
        IList<IOperation> SuccessfullyExecutedOperations { get; }
        IList<IOperation> UnsuccessfullyExecutedOperations { get; }

        bool Execute(IOperation operation);
        void Report();
    }

    class Transaction : ITransaction
    {
        public IList<IOperation> SuccessfullyExecutedOperations { get; private set; }
        public IList<IOperation> UnsuccessfullyExecutedOperations { get; private set; }

        public Transaction()
        {
            SuccessfullyExecutedOperations = new List<IOperation>();
            UnsuccessfullyExecutedOperations = new List<IOperation>();
        }

        public bool Execute(IOperation operation)
        {
            Console.WriteLine($"[INFORMATION] Executing '{operation.GetType().Name} of '{operation.Amount}'...");
            bool executed = operation.Execute();
            if (!executed)
            {
                UnsuccessfullyExecutedOperations.Add(operation);
                return false;
            }

            SuccessfullyExecutedOperations.Add(operation);
            return true;
        }

        public void Report()
        {
            void OperationReport(IList<IOperation> operations, string title)
            {
                Console.WriteLine($"\n>>> {title}");
                foreach(var operation in operations)
                    Console.WriteLine($"{operation.GetType().Name, -30}{operation.Amount, 10}");
            }

            Console.WriteLine();
            Console.WriteLine($"> Transaction Report");
            OperationReport(SuccessfullyExecutedOperations, "Successfull");
            OperationReport(UnsuccessfullyExecutedOperations, "Unsuccessfull");
        }
    }
}
