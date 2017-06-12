using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B, int[] C) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int b = 0;
        int e = C.Length;
        int total = -1;
        if(check(A, B, C, C.Length)) {
            while(b <= e) {
                int mid = (b + e) / 2;
                if(check(A, B, C, mid)) {
                    total = mid;
                    e = mid - 1;
                } else {
                    b = mid + 1;
                }
            }
        }
        return total;
    }
    
    public static bool check(int[] A, int[] B, int[] C, int c) {
        int max = 2 * C.Length + 1;
        int[] prefixSum = new int[max];
        
        for(int i = 0; i < c; i++) {
            prefixSum[C[i]] += 1;
        }
        
        for(int i = 1; i < max; i++) {
            prefixSum[i] += prefixSum[i-1];
        }
        
        for(int i = 0; i < A.Length; i++) {
            if(prefixSum[A[i] - 1] - prefixSum[B[i]] == 0) {
                return false; // no nails in range
            }
        }
        return true;
    }
}
