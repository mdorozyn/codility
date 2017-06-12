using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Length;
        int max = N * 2 + 1;

        var c = new int[max + 1];
        for (int i = 0; i < N; i++)
        {
            c[A[i]]++;
        }

        var result = new int[N];
        for (int i = 0; i < N; i++)
        {
            int r = 0;
            int x = A[i];
            int target = (int)Math.Sqrt(x);
            for (int d = 1; d <= target; d++)
            {
                if (x % d == 0)
                {
                    r += c[d];
                    if (x / d != d)
                    {
                        r += c[x / d];
                    }
                }
            }
            result[i] = N - r;
        }

        return result;
    }
}