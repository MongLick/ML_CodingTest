using System;

public class Solution29
{
	public string solution(string my_string, int n)
	{
		string answer = "";
		char a;

		for (int i = 0; i < my_string.Length; i++)
		{
			for (int j = 0; j < n; j++)
			{
				a = my_string[i];
				answer += a.ToString();
			}
		}

		return answer;
	}
}