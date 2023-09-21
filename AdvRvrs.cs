using System;
using System.Collections.Generic;
class Assignment
{
	public static void Main()
	{
		//Create array
		string[] arr = new string[10];
		Console.WriteLine("Input a sentence using 10 words or less, after each word press 'enter'");
		Console.WriteLine("After sentence is completed, press 'enter' until 10 inputs have been detected");
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = Convert.ToString(Console.ReadLine());
		}
		//Display user sentence
		Console.Write("You're sentence: ");
		for (int j = 0; j < arr.Length; j++)
		{
			Console.Write(arr[j] + " ");
		}
		Console.WriteLine();
		//Convert to Stack
		Stack<string> sentence = new Stack<string>(10);
		for (int t = 0; t < arr.Length; t++)
		{
			sentence.Push(arr[t]);
		}
		Console.Write("Your sentence reversed: ");
		for (int m = 9; m > 0; m--)
		{
			Console.Write(sentence.Peek() + " ");
			sentence.Pop();
		}
		Console.WriteLine(sentence.Peek());
	}
}
