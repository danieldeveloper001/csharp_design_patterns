using System;

namespace Project
{
    public interface IOperation
    {
        IAccount Account { get; }
        decimal Amount { get; }

        bool Execute();
    }

    public class Deposit : IOperation
    {
        public IAccount Account { get; private set; }
        public decimal Amount { get; private set; }

        public Deposit(IAccount account, decimal amount)
        {
            Account = account;
            Amount = amount;
        }

        public bool Execute() => Account.Deposit(Amount);
    }

    public class Interest : IOperation
    {
        public IAccount Account { get; private set; }
        public decimal Amount { get; private set; }

        public Interest(IAccount account, decimal amount)
        {
            Account = account;
            Amount = amount;
        }

        public bool Execute() => Account.Interest(Amount);
    }

    public class Withdrawal : IOperation
    {
        public IAccount Account { get; private set; }
        public decimal Amount { get; private set; }

        public Withdrawal(IAccount account, decimal amount)
        {
            Account = account;
            Amount = amount;
        }

        public bool Execute() => Account.Withdrawal(Amount);
    }
}
