using System;

public class Solution35
{
	public int[] solution(int n)
	{
		int a = 0;
		if (n % 2 == 0)
		{
			a = n / 2;
		}
		else if (n % 2 != 0)
		{
			a = (n + 1) / 2;
		}
		int[] answer = new int[a];

		a = 0;

		for (int i = 1; i <= n; i++)
		{
			if (i % 2 != 0)
			{
				answer[a] = i;
				a++;
			}
		}
		return answer;
	}
}