using System;
namespace CSharp_Programming
{
	public class Student
	{
		// Data Members // Properties

		int studentId;
		string studentName;

		//Member Functions // Behavious // Methods

		public void displayDetails()
		{
			Console.WriteLine("Student ID is" + studentId);
            Console.WriteLine("Student Name is" + studentName);
        }

		public void acceotDetsils()
		{
			Console.WriteLine("Enter The Student Id:");
            studentId = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Student Name:");
			studentName = Console.ReadLine();

			Console.WriteLine();
        }
	}
}

