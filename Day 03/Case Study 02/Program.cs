using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = ReadInt();
        Console.WriteLine(MinOps(10, N));
    }

    static int MinOps(int start, int target)
    {
        if (start == target) return 0;
        
        Queue<(int val, int steps)> q = new Queue<(int, int)>();
        HashSet<int> visited = new HashSet<int>();
        
        q.Enqueue((start, 0));
        visited.Add(start);
        
        int limit = Math.Max(start, target) * 3 + 10; // safe upper bound
        
        while (q.Count > 0)
        {
            var (curr, steps) = q.Dequeue();
            
            int[] next = { curr + 2, curr - 1, curr * 3 };
            
            foreach (int nxt in next)
            {
                if (nxt == target) return steps + 1;
                if (nxt >= 0 && nxt <= limit && !visited.Contains(nxt))
                {
                    visited.Add(nxt);
                    q.Enqueue((nxt, steps + 1));
                }
            }
        }
        return -1; // should not happen for given constraints
    }

    static int ReadInt()
    {
        string? input = Console.ReadLine();
        if (input == null)
            throw new InvalidOperationException("Expected integer input.");
        return int.Parse(input);
    }
}