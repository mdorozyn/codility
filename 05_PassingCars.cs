using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int counter = 0;
        int a = 0;
        
        for(int i = 0; i < A.Length; i++) {
            if(A[i] == 0)
                a++;
            
            if(A[i] == 1)
                counter += a;
        
            if(counter > 1000000000)
                return -1;
        }
            
        return counter;
    }
}