using System;

class Program
{
    static void Main()
    {
        int X = ReadInt();
        int Y = ReadInt();
        int N1 = ReadInt();
        int N2 = ReadInt();
        int M = ReadInt();

        for (int a = N1; a >= 0; a--) // max Type-1 first
        {
            int rem = M - a * X;
            if (rem >= 0 && rem % Y == 0)
            {
                int b = rem / Y;
                if (b >= 0 && b <= N2)
                {
                    Console.WriteLine("Valid");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    return;
                }
            }
        }
        
        Console.WriteLine("Invalid");
    }

    static int ReadInt()
    {
        string? input = Console.ReadLine();
        if (input == null)
            throw new InvalidOperationException("Expected integer input.");
        return int.Parse(input);
    }
}