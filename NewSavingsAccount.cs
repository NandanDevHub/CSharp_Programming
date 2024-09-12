using System;
using CSharp_Programming.Interfaces;

namespace CSharp_Programming
{
    public class NewSavingsAccount : IBankAccount, IManageAccount // Multiple Inheritance
    {
        public void closeAccount()
        {
            Console.WriteLine("Account Closed");
        }

        public void deposit()
        {
            Console.WriteLine("Money Deposited");
        }

        public void openAccount()
        {
            Console.WriteLine("Account Opened");
        }

        public void savings()
        {
            Console.WriteLine("Money Saved");
        }

        public void withdrawal()
        {
            Console.WriteLine("Money Withdrawaled");
        }
    } 
}

