using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
		if(A.Length < 2)
            return 0;
        
        List<int> peaks = new List<int>();
        
        for(int i = 1; i < A.Length-1; i++) {
            if(A[i-1] < A[i] && A[i] > A[i+1])
                peaks.Add(i);
        }
        
        int s = peaks.Count;
		if(s == 1)
			return 1;
		if(s == 0)
			return 0;
		
		s = (int)Math.Ceiling(Math.Sqrt(A.Length));
        
        while(s >= 0) {
			int lp = peaks[0];
			int c = 1;
			for(int i = 1; i < peaks.Count; i++) {
				int d = Math.Abs(peaks[i] - lp);
				if(d >= s) {
					lp = peaks[i];
					c++;
					if(c == s)
						return c;
				}
			}
			s--;
		}
		
		return 0;
    }
}