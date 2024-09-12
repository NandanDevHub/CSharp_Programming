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
Console.WriteLine("----------------------------------------------");

// Classes & Objects
// ----------------------------------------------------------------

// Instansiatinon of Class

Student rancho = new Student();
rancho.acceptDetsils();
rancho.displayDetails();

Console.WriteLine("---------------------Default Constructor-------------------------");
//Default Constructor

Stud defaultStudent = new();
defaultStudent.display();

Console.WriteLine("--------------------Parameterized Constructor--------------------------");
// Parameterized Constructor
Stud parameterizedStudent = new(107, "Rahul");
parameterizedStudent.display();



// Inheritance
Console.WriteLine("-------------------- Single Inheritance--------------------------");

Marks studentMarks = new();
studentMarks.acceptDetsils();
studentMarks.displayDetails();


// Abstarct Class
Console.WriteLine("--------------------Abstract Class--------------------------");


SavingsAccont savingsAccont = new();
savingsAccont.withdrawal();

// As Bank Account class is abstract you cannot be instantiated the object for that class as given below
//BankAccount bankAccount = new();
//bankAccount.withdrawal();



// Interfaces
Console.WriteLine("----------------------Interfaces------------------------");
NewSavingsAccount newSavingsAccount = new();

newSavingsAccount.deposit();
newSavingsAccount.closeAccount();


// Static Classes
Console.WriteLine("----------------------Static Classes------------------------");

//Calculate calculate = new();
// Above will give the error as -  We cannot create an instance of static class


Console.WriteLine(Calculate.count); // Accessing Static Variable

Console.WriteLine(Calculate.increment()); // Accessing Static Methods
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());

Console.WriteLine(Calculate.decrement());
