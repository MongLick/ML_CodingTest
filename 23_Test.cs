using System;

public class Solution23
{
	public int[] solution(int money)
	{
		int[] answer = new int[2];
		int a = 0;
		while (money >= 5500)
		{
			money -= 5500;
			a++;
		}
		answer[0] = a;
		answer[1] = money;
		return answer;
	}
}