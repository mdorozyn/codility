using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int result = 1;
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < A.Length; i++) {
            set.Add(A[i]);
        }
        while(set.Contains(result)) {
            result++;
        }
        return result;
    }
}
