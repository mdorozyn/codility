using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] result = new int[P.Length];
        int[] A = new int[S.Length+1];
        int[] C = new int[S.Length+1];
        int[] G = new int[S.Length+1];
        for(int i = 0; i < S.Length; i++) {
            A[i+1] = A[i] + (S[i] == 'A' ? 1 : 0);
            C[i+1] = C[i] + (S[i] == 'C' ? 1 : 0);
            G[i+1] = G[i] + (S[i] == 'G' ? 1 : 0);
        }
        
        for(int i = 0; i < P.Length; i++) {
            int a = A[Q[i]+1] - A[P[i]];
            int c = C[Q[i]+1] - C[P[i]];
            int g = G[Q[i]+1] - G[P[i]];
            result[i] = a>0 ? 1 : c>0 ? 2 : g>0 ? 3 : 4;
        }
        
        return result;
    }
}