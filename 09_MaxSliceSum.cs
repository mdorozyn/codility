using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] S = new int[A.Length];
        S[0] = A[0];
        for(int i = 1; i < A.Length; i++) {
            S[i] = Math.Max(A[i], A[i]+S[i-1]);
        }
        return S.Max();
    }
}