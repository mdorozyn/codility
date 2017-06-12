using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int K, int M, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int l = A.Max();
        int m = l * A.Length;
        
        while(l < m) {
            int t = (l + m) / 2;
            int i = 0; 
            int j = 0; 
            int s = 0;
            
            while(i < A.Length && j < K) {
                s += A[i];
                if(s > t) {
                    s = A[i];
                    j++;
                }
                i++;
            }
            
            if(j == K)
                l = t + 1;
            else
                m = t;
        }
        return m;
    }
}