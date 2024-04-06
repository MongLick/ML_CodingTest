using System;
using System.Collections;
using System.Linq;

public class Solution22
{
	public int solution(int[] numbers)
	{
		int answer = 0;
		Array.Sort(numbers);
		Array.Reverse(numbers);
		answer = numbers[0] * numbers[1];
		return answer;
	}
}