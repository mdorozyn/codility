using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int count = A.Length;
        Stack<int> upStream = new Stack<int>();
        for(int i = 0; i < A.Length; i++) {
            if(B[i] == 1) {
                upStream.Push(A[i]);
            } else {
                while(upStream.Count > 0) {
                    count--;
                    if(upStream.Peek() > A[i]) {
                        break;
                    } else {
                        upStream.Pop();
                    }
                }
            }
        }
        return count;
    }
}