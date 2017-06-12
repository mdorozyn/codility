using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        int i = 0;
        int j = A.Length - 1;
        int min = int.MaxValue;
        
        while(i <= j) {
            int dif = A[i] + A[j];
            if(dif == 0) 
                return 0;
                
            if(dif < 0) {
                i++;
                dif = -dif;
            } else {
                j--;
            }
            if(min > dif)
                min = dif;
        }
        return min;
    }
}