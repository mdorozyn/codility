using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int L = A.Length;
        int[] result = new int[L];
        int[] Fib = new int[A.Max()+1];
        Fib[0] = Fib[1] = 1;
        
        for(int i = 2; i < Fib.Length; i++)
            Fib[i] = Fib[i-1] + Fib[i-2];
            
        for(int i = 0; i < A.Length; i++)
            result[i] = Fib[A[i]] & ((1 << B[i]) - 1);
        
        return result;
    }
}