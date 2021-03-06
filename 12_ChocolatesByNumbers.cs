using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N, int M) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        return N/gcd(N, M);
        
    }
    
    public static int gcd(int a, int b) {
        if(a % b == 0)
            return b;
        else
            return gcd(b, a % b);
    }
}