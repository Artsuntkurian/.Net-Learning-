using System;
using StudentPerformanceDashboard;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Exercise 1");
        Console.WriteLine("2. Exercise 2");
        Console.WriteLine("3. Exercise 3");
        Console.WriteLine("4. Exercise 4");
        Console.WriteLine("5. Exercise 5");
        Console.WriteLine("6. Case Study");

        Console.Write("Choose: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                Exercise1.Run();
                break;

            case 2:
                Exercise2.Run();
                break;

            case 3:
                Exercise3.Run();
                break;

            case 4:
                Exercise4.Run();
                break;

            case 5:
                Exercise5.Run();
                break;

            case 6:
                AssignmentProgram.Run(Array.Empty<string>());
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}