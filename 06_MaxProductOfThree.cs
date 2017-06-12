using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        
        return Math.Max(A[A.Length-1]*A[A.Length-2]*A[A.Length-3], A[0]*A[1]*A[A.Length-1]);
    }
}