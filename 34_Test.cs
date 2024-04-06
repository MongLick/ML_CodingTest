using System;

public class Solution34
{
	public int solution(int n)
	{
		int answer = 1;
		for (int i = 1; i <= n; i++)
		{
			if (i <= 7)
			{
				answer = 1;
			}
			else if (i % 7 == 0)
			{
				answer++;
			}
		}
		if (n % 7 >= 1 && n > 7)
		{
			answer++;
		}
		return answer;
	}
}