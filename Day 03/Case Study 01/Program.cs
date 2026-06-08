using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

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
}