//Disregard comments about me not figuring it out, I fixed it
using System;
using System.Collections.Generic;
class Exam
{
	public static int Match(string s)
	{
		//Create a stack for each parenthis
		Stack<char> left = new Stack<char>();
		Stack<char> right = new Stack<char>();
		//This is supposed to be where the program checks for '(' or ')' and adds them to the stack
		//However, I can't seem to figure out how to properly implement it
		foreach (char p in s)
		{
			if ('(' == p)
				left.Push(p);
			else if (')' == p)
				right.Push(p);
		}
		//If the two stacks have different counts, there are too many left or right parenthis
		int LC = left.Count;
		int RC = right.Count;
		if (LC > RC)
		{
			int Ldif = LC - RC;
			return Ldif;
		}
		else if (RC > LC)
		{
			int Rdif = RC - LC;
			return Rdif;
		}
		//If the counts of both stacks are the same, the paranthis are matched.
		else
			return 0;
	}
	public static void Main()
	{
		Console.WriteLine("Please input a string to match parenthis: ");
		string input = Convert.ToString(Console.ReadLine());
		int output = Match(input);
		if (output == 0)
			Console.WriteLine("Matched");
		else
			Console.WriteLine(output);
	}
}
