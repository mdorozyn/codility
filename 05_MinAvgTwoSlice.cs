using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int pos = 0;
        float min = float.MaxValue;
        for(int i = 0; i < A.Length-1; i++) {
            float curr = (A[i] + A[i+1]) / 2f;
            if(curr < min) {
                min = curr;
                pos = i;
            }
            
            if(i < A.Length-2) {
                curr = (A[i] + A[i+1] + A[i+2]) / 3f;
                if(curr < min) {
                    min = curr;
                    pos = i;
                }
            }
        }
        
        return pos;
    }
}