using System;

public class Solution15
{
	public int solution(int[] array, int n)
	{
		int answer = 0;
		int a;

		for (int i = 0; i < array.Length; i++)
		{
			a = array[i];
			if (a == n)
			{
				answer++;
			}
		}

		return answer;
	}
}