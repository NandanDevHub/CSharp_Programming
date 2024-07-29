using System;
namespace CSharp_Programming
{
	public class JumpStatements
	{
		public void Jumps()
		{
			for (int i = 1; i <= 10; i++)
			{
				if (i == 5) break;
				{
					Console.WriteLine("Value of I" + i);
					Console.WriteLine("---------------");
				}

				if (i == 7) continue;
				{
					Console.WriteLine("Values of I" + i);
				}
			}
		}
	}
}

