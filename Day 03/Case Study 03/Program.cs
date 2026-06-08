using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        if (n > s.Length)
        {
            Console.WriteLine("Invalid");
            return;
        }

        int need = n / 2; // at least n/2 consecutive

        for (int i = 0; i <= s.Length - n; i++)
        {
            string sub = s.Substring(i, n);

            // Check if substring has only P, S, G
            bool validChars = true;
            foreach (char c in sub)
            {
                if (c!= 'P' && c!= 'S' && c!= 'G')
                {
                    validChars = false;
                    break;
                }
            }
            if (!validChars) continue;

            // Check for n/2 consecutive P/S/G
            int cnt = 1;
            for (int j = 1; j < n; j++)
            {
                if (sub[j] == sub[j - 1])
                    cnt++;
                else
                    cnt = 1;

                if (cnt >= need)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
        }

        Console.WriteLine("No");
    }
}