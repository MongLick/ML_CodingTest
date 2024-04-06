using System;
using System.Linq;

public class Solution20
{
	public string solution(string my_string)
	{
		string answer = "";

		char[] charArr = my_string.ToArray();
		Array.Reverse(charArr);
		answer = new string(charArr);

		return answer;
	}
}