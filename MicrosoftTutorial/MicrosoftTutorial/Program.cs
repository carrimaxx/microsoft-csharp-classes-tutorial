using System;

namespace MicrosoftTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            var account = new BankAccount("Louie", 88599.70M);
            Console.WriteLine($"Account {account.AccountNumber} has been created for {account.Owner} with {account.Balance} initial balance.");
            
            account.MakeWithdrawal(1500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(2000, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException) // or (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                //Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine($"Total balance as of {DateTime.Now}: ${account.Balance}");
        }
    }
}
