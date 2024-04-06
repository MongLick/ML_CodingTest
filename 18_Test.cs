using System;

public class Solution18
{
	public int solution(int n, int k)
	{
		int answer = 0;
		int a = 12000;
		int b = 2000;

		answer += a * n;
		answer += b * k;

		while (n > 9)
		{
			n -= 10;
			answer -= b;
		}
		return answer;
	}
}