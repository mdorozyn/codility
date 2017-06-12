using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int M, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        const int MAX = 1000000000;
        bool[] seen = new bool[M+1];
        int begin = 0;
        int end = 0;
        int count = 0;
        while(begin < A.Length && end < A.Length) {
            if(seen[A[end]]) {
                seen[A[begin]] = false;
                begin++;
            } else {
                count += end - begin + 1;
                if(count >= MAX) 
                    return MAX;
                
                seen[A[end]] = true;
                end++;
            }
        }
        return count;
    }
}
