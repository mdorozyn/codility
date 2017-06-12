using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int count = 0;
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < H.Length; i++) {
            while(stack.Count > 0 && stack.Peek() > H[i]) {
                stack.Pop();
            }
            
            if(stack.Count == 0 || stack.Peek() < H[i]) {
                stack.Push(H[i]);
                count++;
            }
        }
        return count;
    }
}