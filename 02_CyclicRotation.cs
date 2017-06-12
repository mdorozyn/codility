using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length == 0 || K == 0 || K%A.Length == 0)
            return A;
        
        for(int i = 0; i < K; i++) {
            int tmp = A[A.Length-1];
            for(int j = A.Length - 1; j >= 0; j--) {
                if(j == 0)
                    A[j] = tmp;
                else
                    A[j] = A[j-1];
            }
        }
        
        return A;
    }
}