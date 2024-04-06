using System;
using System.Text.RegularExpressions;

public class Solution31
{
	public string solution(string my_string)
	{
		string answer = "";
		string subStringList = "[aeiou]";
		answer = Regex.Replace(my_string, subStringList, "");

		return answer;
	}
}