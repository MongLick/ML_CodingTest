using System;
using System.Collections.Generic;
public class Solution14
{
	public int[] solution(string[] strlist)
	{
		List<int> list = new List<int>();
		foreach (string element in strlist)
		{
			list.Add(element.Length);
		}
		return list.ToArray();
	}
}