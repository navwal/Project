using System;
class Assignment
{
	public static void Mystery(int x)
	{
		if( x == 1)
			Console.WriteLine("pooh");
		else if( x % 2 == 0)
		{
			Console.WriteLine(x);
			Mystery(x/2);
		}
		else
			Mystery(x-1);
	}
	public static void Main()
	{
		Mystery(-1);
	}
}
