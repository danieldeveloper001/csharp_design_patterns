using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            var transaction = new Transaction();

            Console.WriteLine();
            Console.WriteLine($"> Operation Execution");
            transaction.Execute(new Deposit(account, 1000));
            transaction.Execute(new Withdrawal(account, -250));
            transaction.Execute(new Withdrawal(account, 500));
            transaction.Execute(new Deposit(account, -250));
            transaction.Execute(new Withdrawal(account, 250));
            transaction.Execute(new Deposit(account, 750));
            transaction.Execute(new Interest(account, 0.1M));

            transaction.Report();
            account.Report();
        }
    }
}
