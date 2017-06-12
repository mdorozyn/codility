using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] counters = new int[N];
        int max = 0;
        int last_max = 0;
        for(int i = 0; i < A.Length; i++) {
            if(A[i] <= N) {
                counters[A[i]-1] = Math.Max(last_max, counters[A[i]-1]) + 1;
                max = Math.Max(max, counters[A[i]-1]);
            } else {
                last_max = max;
            }
        }
        for(int i = 0; i < N; i++) {
            counters[i] = Math.Max(counters[i], last_max);
        }
        return counters;
    }
}