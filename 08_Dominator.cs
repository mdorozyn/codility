using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int size = 0;
        int value = 0;
        for(int i = 0; i < A.Length; i++) {
            if(size == 0) {
                size++;
                value = A[i];
            } else {
                if(value != A[i])
                    size--;
                else
                    size++;
            }
        }
        int candidate = -1;
        if(size > 0)
            candidate = value;
        int count = 0;
        int pos = -1;
        for(int i = 0; i < A.Length; i++) {
            if(A[i] == candidate) {
                count++;
                pos = i;
            }
        }
        if(count <= A.Length/2)
            pos = -1;
            
        return pos;
    }
}