using System;
namespace CSharp_Programming
{
	static class CheckExtension
	{
		public static bool IsGreaterThan(this int i, int value)
		{
			return i > value;
		}
	}
}

