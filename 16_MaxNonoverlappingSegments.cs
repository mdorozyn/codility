using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int len = A.Length;
        if(len == 0)
            return 0;
        
        int last = B[len-1] + 1;
        int count = 0;
        
        for(int i = len - 1; i >= 0; i--) {
            if(B[i] < last) {
                count++;
                last = A[i];
            } else if (A[i] > last) {
                last = A[i];
            }
        }
        return count;
    }
}