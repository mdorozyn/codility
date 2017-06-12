using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var leftSums = new int[A.Length - 2];
        var rightSums = new int[A.Length - 2];

        for (int i = 0; i < A.Length - 3; i++) {
            leftSums[i + 1] = Math.Max(0, leftSums[i] + A[i + 1]);
            rightSums[A.Length - 3 - i - 1] = Math.Max(0, rightSums[A.Length - 3 - i] + A[A.Length - 3 - i + 1]);
        }
        
        var maxSum = int.MinValue;
        for (int i = 0; i < A.Length - 2; i++) {
            maxSum = Math.Max(maxSum, leftSums[i] + rightSums[i]);
        }
        return maxSum;
    }
}