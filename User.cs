using System;
namespace CSharp_Programming
{
	public class User
	{
		private string name;
		private string companyName;
		private int age;
		private string City { get; set; }


		public User()
		{
			companyName = "Emerson";
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string CompanyName
		{
			get { return companyName; }
		}

		public int Age
		{
			get { return age; }
			set {
				// Property Validation
				if (value < 18)
					throw new ArithmeticException("Invalid Age");

				age = value; }
		}
	}
}

