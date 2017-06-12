using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int current = 0;
        int max = 0;
        
        while(N>0 && N%2 == 0) {
            N /= 2;
        }
        
        while(N>0){
            if(N%2 == 0){
                current++;
            } else {
                if(current >= max) {
                    max = current;
                }
                current = 0;
            }
            N /= 2;
        }
        
        return max;
    }
}