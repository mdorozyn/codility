using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int K, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int sum = 0;
        int ropes = 0;
        
        for(int i = 0; i < A.Length; i++) {
            sum += A[i];
            if(sum >= K) {
                sum = 0;
                ropes++;
            }
        }
        return ropes;
    }
}