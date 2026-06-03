using System;
using System.Collections.Generic;

class Exercise4
{
    public static void Run()
    {
        List<string> employees = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter Employee {i} Name: ");
            string employeeName = Console.ReadLine() ?? string.Empty;
            employees.Add(employeeName);
        }

        Console.WriteLine("\nEmployee Names:");

        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}