using System;
namespace CSharp_Programming
{
	public class Marks :Student
	{
		float objectiveMarks;
		float subjectiveMarks;

        public void displayDetails()
        {
            base.displayDetails(); // This will first call Parent class
            Console.WriteLine("Objective Marks are " + objectiveMarks);
            Console.WriteLine("Subjective Marks are " + subjectiveMarks);
        }

        public void acceptDetsils()
        {
            base.acceptDetsils(); // This will first call Parent class
            Console.WriteLine("Enter The Objective Marks:");

            objectiveMarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Subjective Marks");
            subjectiveMarks = float.Parse(Console.ReadLine());

            Console.WriteLine();
        }
    }
}

