using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int min = Int32.MaxValue;
        int left = 0;
        int right = A.Sum();
        for(int i = 0; i < A.Length-1; i++) {
            left += A[i];
            right -= A[i];
            
            int current = (int)Math.Abs(left - right);
            if(current < min)
                min = current;
        }
        return min;
    }
}
