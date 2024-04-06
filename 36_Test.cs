using System;
using System.Linq;

public class Solution36
{
	public int solution(int[] sides)
	{
		int answer = 0;

		int max = sides.Max();
		Array.Sort(sides);

		if (sides[0] + sides[1] > max)
		{
			answer = 1;
		}
		else
		{
			answer = 2;
		}

		return answer;
	}
}