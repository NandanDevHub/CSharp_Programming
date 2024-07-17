float baseSalary = 50000;
float hra = 0.5F;

float netSalary = baseSalary - (baseSalary * hra);

Console.WriteLine("The Base Salary is: " + baseSalary);
Console.WriteLine("The Salary credited in account will be: " + netSalary);

bool isAuthenticated = true;

string result = isAuthenticated ? "logged in" : "logged out";
Console.WriteLine(result);

switch (result)
{
    case ("logged in"):
        Console.WriteLine("You are in control");
        break;

    case ("logged out"):
        Console.WriteLine("You do not have access");
        break;

    default:
        Console.WriteLine("Denied");
        break;
}

string[] names = new string[5] { "Shikhar Dhawan", "Rohit Sharma", "Virat Kohli", "Suresh Raina", "MS Dhoni" };

//