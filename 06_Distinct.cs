using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length == 0)
            return 0;
            
        int result = 1;
        Array.Sort(A);
        for(int i = 0; i < A.Length-1; i++) {
            if(A[i] != A[i+1])
                result++;
        }
                
        return result;
    }
}