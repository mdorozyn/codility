using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(X > A.Length)
            return -1;
        bool[] map = new bool[X+1];
        int counter = X;
        for(int i = 0; i < A.Length; i++) {
            if(!map[A[i]]) {
                map[A[i]] = true;
                counter--;
            }
            
            if(counter == 0)
                return i;
        }
        return -1;
    }
}