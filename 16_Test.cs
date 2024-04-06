using System;

public class Solution16
{
	public int[] solution(int[] num_list)
	{
		int[] answer = new int[2];

		foreach (int a in num_list)
		{
			if (a % 2 == 0)
			{
				answer[0]++;
			}
			else
			{
				answer[1]++;
			}
		}

		return answer;
	}
}