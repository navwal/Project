using System;
class Fibonacci
{
	public static int Fib(int n)
	{
		int a = 0;
		int b = 1;
		for (int i = 0; i < n; i++)
		{
			int temp = a;
			a = b;
			b = temp + a;
		}
		return a;
	}
	public static void Main()
	{
		int num = 10;
		for(int i = 0; i < num + 1; i++)
			Console.WriteLine(Fib(i));
	}
}
