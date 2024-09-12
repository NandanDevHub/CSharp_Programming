using System;
using CSharp_Programming.Interfaces;

namespace CSharp_Programming
{
    public class NewSavingsAccount : IBankAccount
    {
        public void deposit()
        {
            Console.WriteLine("Money Deposited");
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

