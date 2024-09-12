using System;
namespace CSharp_Programming
{
	static class Calculate
	{
		//int count = 0;
		// Above This will give you error of instance member in static class

		public static int count = 0;

		//Calculate() { }
		// Above will give you error as Static classes cannot have instance constructors

		static Calculate()
		{
			count = 0;
		}

		public static int increment()
		{
			count++;
			return count;
		}

		public static int decrement()
		{
			count--;
			return count;
		}
	}

	public class ExtnMethods
	{
		 public int number = 314;
		bool result;

		public ExtnMethods()
		{
            result = number.IsGreaterThan(2000);
        }
	}
}

