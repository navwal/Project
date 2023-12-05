using System;
using System.Collections.Generic;
public class SQ
{
	public static void Main()
	{
		//Create Stack/Queue
		Stack<char> stack = new Stack<char>(4);
		Queue<char> q = new Queue<char>();
		stack.Push('A');
		stack.Push('B');
		stack.Push('C');
		stack.Push('D');
		//Copy to Queue
		for (int i = 0; i < 4; i++)
		{
			q.Enqueue(stack.Peek());
			stack.Pop();
		}
		//Dequeue
		q.Dequeue();
		q.Dequeue();
		Console.WriteLine(Convert.ToChar(q.Peek()));
		q.Dequeue();
		Console.WriteLine(Convert.ToChar(q.Peek()));
	}
}
