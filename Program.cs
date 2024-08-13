using CSharp_Programming;

float baseSalary = 50000;
float hra = 0.5F;

float netSalary = baseSalary - (baseSalary * hra);

Console.WriteLine("The Base Salary is: " + baseSalary);
Console.WriteLine("The Salary credited in account will be: " + netSalary);

Console.WriteLine("----------------------------------------------");
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
Console.WriteLine("----------------------------------------------");
Loops loops = new();
loops.Looping();

JumpStatements Jp = new();
Jp.Jumps();

ManipArrays manip = new();
manip.OneDArray();
manip.TwoDArray();
Console.WriteLine();


// Classes & Objects
// ----------------------------------------------------------------

// Instansiatinon of Class

Student rancho = new Student();
rancho.acceotDetsils();
rancho.displayDetails();