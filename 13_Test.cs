using System;
using System.Collections.Generic;

public class Solution13
{
	public List<int> solution(int[] num_list)
	{

		Stack<int> s = new Stack<int>();
		List<int> list = new List<int>();

		foreach (int a in num_list)
		{
			s.Push(a);
		}

		while (s.Count > 0)
		{
			list.Add(s.Pop());
		}

		return list;
	}
}