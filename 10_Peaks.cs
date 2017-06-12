using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length < 3)
            return 0;
        
        List<int> peaks = new List<int>();
        
        for(int i = 1; i < A.Length-1; i++) {
            if(A[i-1] < A[i] && A[i] > A[i+1])
                peaks.Add(i);
        }
        
        if(peaks.Count == 0)
            return 0;
            
        for(int i = peaks.Count; i > 0; i--) {
            if(A.Length % i == 0) {
                int block_size = A.Length / i;
                bool[] found = new bool[i];
                int found_counter = 0;
                
                foreach(int peak in peaks) {
                    int block_number = peak / block_size;
                    if(found[block_number] == false) {
                        found[block_number] = true;
                        found_counter++;
                    }
                }
                
                if(found_counter == i)
                    return i;
            }
        }
        
        return 0;
    }
}