using System;
namespace CSharp_Programming
{
	public class Loops
	{
		public Loops()
		{

        }

		public void Looping()
		{
		 int i;
         string[] names = new string[5] { "Shikhar Dhawan", "Rohit Sharma", "Virat Kohli", "Suresh Raina", "MS Dhoni" };

			// FOR LOOP - Choronological Order
			for (i = 0; i < names.Length; i++)
				Console.WriteLine(names[i]);

            Console.WriteLine("----------------------------------------------");

			// FOR LOOP - Reverse Order

			for (i = 4; i >= 0; i--)
				Console.WriteLine(names[i]);

            Console.WriteLine("----------------------------------------------");

			// While Loop
			i = 0;
			while (i < names.Length)
			{
				Console.WriteLine(names[i]);
				i++;
			}
        }
    }
}

