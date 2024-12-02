using System;
namespace CSharp_Programming
{
	public partial class Employee
	{
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee Id:" + EmpId);
            Console.WriteLine("Employee Name:" + EmpName);
        }
    }
}

