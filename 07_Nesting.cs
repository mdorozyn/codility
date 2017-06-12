using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(S == null || S.Length == 1)
			return 0;
		if(S.Length == 0)
			return 1;
		if(S.Length%2 == 1)
			return 0;
		
		char[] stack = new char[S.Length];
		int pos = 0;
		for(int i = 0; i < S.Length; i++) {
		    if( S[i] == '(') {
                stack[pos] = S[i];
                pos++;
            } else {
                if(i == 0 || pos == 0)
                    return 0;
                
                if(S[i] == ')' && stack[pos-1] != '(')
                    return 0;
                
                pos--;
            }
			
			if(pos < 0)
				return 0;
        }
        return (pos == 0 ? 1 : 0);
    }
}