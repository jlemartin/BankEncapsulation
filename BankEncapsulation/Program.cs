using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of the BankAccount class
            var account1 = new BankAccount();

            Console.WriteLine($"Current balance: {account1.GetBalance()}");

            // Allow the user of the application to Deposit money
            Console.Write("Enter deposit amount:");
            var amount = Convert.ToDouble(Console.ReadLine());
            account1.Deposit(amount);

            // and retrieve their balance through the console
            Console.WriteLine($"New balance: {account1.GetBalance()}");


        }
    }
}
