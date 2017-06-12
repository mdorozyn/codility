using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] maxInt = new int[A.Length];
        maxInt[0] = A[0];
        maxInt[1] = A[0] + A[1];
        
        for(int i = 2; i < A.Length; i++) {
            int max = int.MinValue;
            for(int j = 1; j <= 6; j++) {
                if(i - j >= 0) {
                    max = Math.Max(max, maxInt[i-j] + A[i]);
                }
            }
            maxInt[i] = max;
        }
        return maxInt[A.Length - 1];
    }
}