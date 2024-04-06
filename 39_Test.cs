using System;

public class Solution39
{
	public int solution(int[] array)
	{
		int answer = 0;
		int a;
		Array.Sort(array);

		a = array.Length / 2;
		answer = array[a];

		return answer;
	}
}