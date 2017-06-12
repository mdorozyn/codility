using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //for N = 0, 1, 2, the distance to jump from `-1' (the origin)
		//can be 1, 2, 3. then we know these a fibonacci number.
		int N = A.Length;
		
		if (N <= 2){
			return 1;
		}
		
		//each reached[i] cell remembers the minimum jumps made to reach there so far.
		int[] reached = new int[N];
		
		//these two cells can be reached when there are leaves there.
		//since 0 and 1 can be reached by the first jump, we only care if 
		//there is a leaf or not.
		reached[0] = A[0]; 
		reached[1] = A[1];
		
		//we now N <= 100,000. Since fib(25) == 75025, fib(26) = 121393,
		//we only have to generate 25 fibonacci numbers.
		
		int[] Fib = new int[26];
		Fib[0] = 0;
		Fib[1] = 1;
		
		for(int i = 2; i < Fib.Length; i++) {
			Fib[i] = Fib[i-1] + Fib[i-2];
			
			//if one jump is enough, we can simply return here.
			if (Fib[i] - 1 == N){
				return 1;
			}
			
			//we also mark the position that can be reached by the first jump.
			if (Fib[i] - 1 < N && A[Fib[i] - 1] == 1){
				reached[Fib[i] - 1] = 1; 
			}
		}
		
		//let's check each cell
		int min = int.MaxValue;
		for (int i = 0; i < N; i++){
			//if the cell is not reachable, we can neglect it.
			if (reached[i] == 0){   
				continue;
			}
			int min_jumps_to_here = reached[i];
			int j;
			
			for (j = 2; j < Fib.Length; j++){
				int next_pos = i + Fib[j];            
				
				//if we can reach the other bank (the position N),
				// update min if necessary.
				if (next_pos == N){
					min = min_jumps_to_here + 1 < min ? min_jumps_to_here + 1 : min;
					break;
				}
				
				//if the next jump is too large, or there is no leaf there,
				//we can neglect this jump.
				if (next_pos > N || A[next_pos] == 0){
					continue;
				}
							
				//if we have never reached to the next position before, or we can reach 
				//the next position with less jumps, update the min number of jumps
				// at the position.
				if (reached[next_pos] == 0 || 
					reached[next_pos] > min_jumps_to_here + 1){
					reached[next_pos] = min_jumps_to_here + 1;
				}
			}
		}
		
		return min == int.MaxValue ? -1 : min;

    }
}