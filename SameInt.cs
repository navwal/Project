using System;
using System.Collections.Generic;
class LeetCode
{
	static string Same(string str)
	{
		string subString = string.Empty;
		string ans = string.Empty;

		for (int i = 0; i <= str.Length - 3; i += 1)
		{
			if (str[i] == str[i + 1] && str[i + 1] == str[i + 2])
			{
				if (ans == string.Empty)
				{
					ans = str.Substring(i, 3);
				}
				else
				{
					subString = str.Substring(i, 3);

					if (subString.CompareTo(ans) > 0)
					{
						ans = subString;
					}
				}
			}
		}
		return ans;
	}
	static void Main()
	{
		Console.WriteLine("please insert a string of numbers: ");
		Console.WriteLine("Press 'enter' when you are complete: ");
		string input = Convert.ToString(Console.ReadLine());
		string output = Same(input);
		Console.WriteLine("Largest Good Integer: " + "\n" + output);
	}
}
