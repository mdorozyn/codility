using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int m = P.Length;
        int[] M = new int[m];
        int[] F = new int[N+1];
        int i = 2;
        while(i * i <= N) {
            if(F[i] == 0) {
                int k = i * i;
                while(k <= N) {
                    if(F[k] == 0)
                        F[k] = i;
                    k += i;
                }
            }
            i++;
        }
        
        int[] semi = new int[N+1];
        int sum = 0;
        
        for(int k = 1; k <= N; k++) {
            if(F[k] != 0) {
                int b = k / F[k];
                if(F[b] == 0) {
                    sum++;
                }
            }
            semi[k] = sum;
        }
        
        for(int mi = 0; mi < m; mi++) {
            int p = P[mi];
            int q = Q[mi];
            M[mi] = semi[q] - semi[p-1];
        }
        return M;
    }
}