using System;
namespace CSharp_Programming
{
	enum WeekDays:byte
	{
		Monday,
		Tuesday = 33, // Re-assign their values
		Wednesday,
		Thrusday,
		Friday,
		Saturday,
		Sunday
	}

	public class Enums
	{
        public void displayWeekDays()
		{
			Console.WriteLine(WeekDays.Friday);
			Console.WriteLine(WeekDays.Wednesday);

			//To get the integral value of what they represent
			int day = (int)WeekDays.Sunday; // Type of Interger Type
			Console.WriteLine(WeekDays.Sunday + ":" + day);

			day = (int)WeekDays.Tuesday;
			Console.WriteLine(WeekDays.Tuesday + ":" + day);
		}
	}
}

