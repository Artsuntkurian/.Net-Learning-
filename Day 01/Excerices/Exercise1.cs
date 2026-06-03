using System;

class Exercise1
{
    public static void Run()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Age: ");
        string ageInput = Console.ReadLine() ?? string.Empty;
        int age = Convert.ToInt32(ageInput);

        Console.WriteLine($"\nName: {name}");
        Console.WriteLine($"Age: {age}");
    }
}