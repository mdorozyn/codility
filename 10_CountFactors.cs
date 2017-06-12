using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        double limit = Math.Sqrt(N);
		int i = 1;
        int result = 0;
        for(; i < limit; i++) {
            if(N % i == 0)
                result += 2;
        }
        
        if((long)(i*i) == N)
            result++;
            
        return result;
    }
}