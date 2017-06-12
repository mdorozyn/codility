using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        for(int i = (int)Math.Sqrt(N); i > 0; i--) {
            if(N%i == 0)
                return 2*(i+(N/i));
        }
        return -1;
    }
}