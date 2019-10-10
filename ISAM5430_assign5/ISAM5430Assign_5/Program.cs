using System;

namespace ISAM5430Assign_5
{
    class Program
    {
        static void Main()
        {
            Account account1 = new Account("Himani Saxena", 50.0m);
            Account account2 = new Account("Jake William", 180.0m);
            Console.WriteLine($"Initial bal of {account1.Name} is {account1.Balance}");
            Console.WriteLine($"Initial bal of {account2.Name} is {account2.Balance}");

            //Console.Write("Enter deposit amount for account1");
            //decimal depositAmount1 = decimal.Parse(Console.ReadLine());
            //Console.Write("Enter deposit amount for account2");
            //decimal depositAmount2 = decimal.Parse(Console.ReadLine());
            //account1.Deposit(depositAmount1);
            //account2.Deposit(depositAmount2);
            Console.Write("Enter withdrawal amount for account1");
            decimal withdrawalAmount1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter withdrawal amount for account2");
            decimal withdrawalAmount2 = decimal.Parse(Console.ReadLine());
            account1.Withdrawal(withdrawalAmount1);
            account2.Withdrawal(withdrawalAmount2);

            Console.WriteLine($"Balance for {account1.Name} after withdrawal is {account1.Balance}");
            Console.WriteLine($"Balance for {account2.Name} after withdrawal is {account2.Balance}");

        }
    }
}
