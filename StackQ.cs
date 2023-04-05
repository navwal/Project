using System.Collections.Generic;
using System;
class Assignment
{
	public static void Main()
	{
		Stack<int> stack = new Stack<int>(3);
		Queue<int> q = new Queue<int>();

		//Create an input order for the Queue/Stack
		int[] arr = new int[3];
		Console.WriteLine("Please input 3 integers:");
		for (int i = 0; i < arr.Length; i++)
			arr[i] = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input order");
		for (int i = 0; i < arr.Length; i++)
		       Console.WriteLine("{0}", arr[i]);
		
		//Queue/Stack input
		for (int i = 0; i < arr.Length; i++)
		{
			stack.Push(arr[i]);
			q.Enqueue(arr[i]);
		}

		//Stack output
		Console.WriteLine("Stack output order:");
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine(Convert.ToInt32(stack.Peek()));
			stack.Pop();
		}

		//Queue output
		Console.WriteLine("Queue output order:");
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine(Convert.ToInt32(q.Peek()));
			q.Dequeue();
		}
	}
}


