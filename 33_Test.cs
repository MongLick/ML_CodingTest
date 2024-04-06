using System;

public class Solution33
{
	public int solution(int slice, int n)
	{
		int answer = 0;
		double a;

		a = (double)n / slice;
		a = Math.Ceiling(a);
		answer = (int)a;
		return answer;

	}
}