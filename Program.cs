﻿using CSharp_Programming;

int switchID;
Console.WriteLine("Please Enter the Number to proceed: ");
switchID = int.Parse(Console.ReadLine());

switch (switchID)
{
    case 1:

        //Basic Datatypes
        float baseSalary = 50000;
        float hra = 0.5F;

        float netSalary = baseSalary - (baseSalary * hra);

        Console.WriteLine("The Base Salary is: " + baseSalary);
        Console.WriteLine("The Salary credited in account will be: " + netSalary);
        break;

    case 2:

        // Boolean & Ternary Ops
        // Switch Case
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
        break;

    case 3:

        // Loops
        Loops loops = new();
        loops.Looping();
        break;

    case 4:

        // Jump Statements
        JumpStatements Jp = new();
        Jp.Jumps();
        break;

    case 5:

        //Arrays
        ManipArrays manip = new();
        manip.OneDArray();
        manip.TwoDArray();
        Console.WriteLine("----------------------------------------------");
        break;

    case 6:

        //Classes & Objects
        // Instansiatinon of Class

        Student rancho = new Student();
        rancho.acceptDetsils();
        rancho.displayDetails();
        break;

    case 7:

        Console.WriteLine("---------------------Default Constructor-------------------------");
        //Default Constructor

        Stud defaultStudent = new();
        defaultStudent.display();

        Console.WriteLine("--------------------Parameterized Constructor--------------------------");
        // Parameterized Constructor
        Stud parameterizedStudent = new(107, "Rahul");
        parameterizedStudent.display();
        break;

    case 8:
        // Inheritance
        Console.WriteLine("-------------------- Single Inheritance--------------------------");

        Marks studentMarks = new();
        studentMarks.acceptDetsils();
        studentMarks.displayDetails();
        break;

    case 9:
        // Abstarct Class
        Console.WriteLine("--------------------Abstract Class--------------------------");


        SavingsAccont savingsAccont = new();
        savingsAccont.withdrawal();

        // As Bank Account class is abstract you cannot be instantiated the object for that class as given below
        //BankAccount bankAccount = new();
        //bankAccount.withdrawal();
        break;

    case 10:

        // Interfaces
        Console.WriteLine("----------------------Interfaces------------------------");
        NewSavingsAccount newSavingsAccount = new();

        newSavingsAccount.deposit();
        newSavingsAccount.closeAccount();
        break;

    case 11:
        // Static Classes
        Console.WriteLine("----------------------Static Classes------------------------");

        //Calculate calculate = new();
        // Above will give the error as -  We cannot create an instance of static class


        Console.WriteLine(Calculate.count); // Accessing Static Variable

        Console.WriteLine(Calculate.increment()); // Accessing Static Methods
        Console.WriteLine(Calculate.increment());
        Console.WriteLine(Calculate.increment());
        Console.WriteLine(Calculate.decrement());
        break;

    case 12:
        Console.WriteLine("----------------------Partial Classes & Methods------------------------");
        var employee = new Employee();
        employee.DisplayDetails();
        break;

    case 13:
        Console.WriteLine("------ Properties in C# ------");
        User user = new()
        // Here it automatically sets Name
        {
            Name = "Nandan"
        };
        Console.WriteLine(user.Name);

        //user.CompanyName = "The Big Tech";
        //  Property user.CompanyName cannot be assigned because it is a read-only.
        //  You cannot set a new value here.

        Console.WriteLine(user.CompanyName);

        user.Age = 12;

        break;
}
















