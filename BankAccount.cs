using System;
namespace CSharp_Programming
{

	//Abstarct Classes & methods
	public abstract class BankAccount
	{
		public abstract void deposit(); // Abstract Methods have no body

		public abstract void withdrawal(); // Abstract Methods have no body

        public abstract void savings(); // Abstract Methods have no body
    }

    public class SavingsAccont : BankAccount // Inheriting
    {
        public override void deposit() // Now we can access the abstract class methods
        {
            Console.WriteLine("Money in Deposit");
        }

        public override void savings()
        {
            Console.WriteLine("Money in Savings");
        }

        public override void withdrawal()
        {
            Console.WriteLine("Money Withdrawal");
        }
    }
}

