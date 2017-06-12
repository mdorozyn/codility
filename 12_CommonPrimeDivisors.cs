using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int res = 0;
        
        for(int i = 0; i < A.Length; i++) {
            int a = A[i];
            int b = B[i];
            int g = gcd(a, b);
            
            int c = 0;
            while(c != 1) {
                c = gcd(a, g);
                a /= c;
            }
            
            c = 0;
            while(c != 1) {
                c = gcd(b, g);
                b /= c;
            }
            
            if(a == 1 && b ==1)
                res++;
            
        }
        
        return res;
    }
    
    public static int gcd(int a, int b) {
        if(a % b == 0)
            return b;
        else
            return gcd(b, a % b);
    }
}