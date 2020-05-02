using System;

namespace Project
{
    public interface IAccount
    {
        decimal Balance { get; }

        bool Deposit(decimal amount);
        bool Interest(decimal amount);
        bool Withdrawal(decimal amount);
        void Report();
    }

    public class Account : IAccount
    {
        public decimal Balance { get; private set; }

        private bool IsValidAmount(decimal amount, string operation)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"[ERROR] The {operation.ToLower()} amount should be greater than zero!");
                return false;
            }

            return true;
        }

        public bool Deposit(decimal amount)
        {
            if (!IsValidAmount(amount, nameof(Deposit)))
                return false;

            Balance += amount;

            Console.WriteLine($"[SUCCESS] '{nameof(Deposit)}' of '{amount}', current balance is '{Balance}'!");
            return true;
        }

        public bool Interest(decimal amount)
        {
            if (!IsValidAmount(amount, nameof(Interest)))
                return false;

            Balance *= (1 + amount);

            Console.WriteLine($"[SUCCESS] '{nameof(Interest)}' of '{amount}', current balance is '{Balance}'!");
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            bool IsWithdrawalAuthorized(decimal amount)
            {
                var result = Balance - amount;
                if (result < 0)
                {
                    Console.WriteLine(
                        $"[ERROR] '{nameof(Withdrawal)}' of '{amount}' unauthorized, current balance is '{Balance}'!");
                    return false;
                }

                return true;
            }

            if (!IsValidAmount(amount, nameof(Withdrawal)))
                return false;

            if (!IsWithdrawalAuthorized(amount))
                return false;

            Balance -= amount;

            Console.WriteLine($"[SUCCESS] '{nameof(Withdrawal)}' of '{amount}', current balance is '{Balance}'!");
            return true;
        }

        public void Report()
        {
            Console.WriteLine();
            Console.WriteLine($"> Account Report");
            Console.WriteLine($"{nameof(Balance), -30}{Balance, 10}");
        }
    }
}
