using System;
namespace CSharp_Programming
{
	public class Student
	{
		// Data Members // Properties

		int studentId;
		string studentName;

		//Default Constructors
		public Student()
		{
			studentId = 10;
			studentName = "Annomynus";
		}

		//Parameterized Constructor
		public Student(int sid, string sName)
		{
			studentId = sid;
			studentName = sName;
		}

		//Member Functions // Behavious // Methods

		public void displayDetails()
		{
			Console.WriteLine("Student ID is" + studentId);
            Console.WriteLine("Student Name is" + studentName);
        }

		public void acceptDetsils()
		{
			Console.WriteLine("Enter The Student Id:");
            studentId = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Student Name:");
			studentName = Console.ReadLine();

			Console.WriteLine();
        }
    }

	public class Stud
	{
        int studId;
        string studName;

        //Default Constructors
        public Stud()
        {
            studId = 10;
            studName = "Annomynus";
        }

        //Parameterized Constructor
        public Stud(int sid, string sName)
        {
            studId = sid;
            studName = sName;
        }


        // For Understanding Constructors

        public void display()
        {
            Console.WriteLine("Student ID is" + studId);
            Console.WriteLine("Student Name is" + studName);
        }
    }
}

