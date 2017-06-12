using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int min_price = int.MaxValue;
        int max_profit = 0;
        for(int i = 0; i < A.Length; i++) {
            min_price = Math.Min(min_price, A[i]);
            max_profit = Math.Max(max_profit, A[i] - min_price);
        }
        return max_profit;
    }
}