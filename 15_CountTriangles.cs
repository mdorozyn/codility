using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length < 3)
            return 0;
        
        int N = A.Length;
        Array.Sort(A);
        int result = 0;
        
        for(int x = 0; x < N; x++) {
            int z = x + 2;
            for(int y = x + 1; y < N; y++) {
                while(z < N && A[x] + A[y] > A[z])
                    z++;
                
                result += z - y - 1;
            }
        }
        return result;
    }
}