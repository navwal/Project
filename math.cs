using System;
class Math
{
	static void Main()
	{
		int a = 1;
		int b = 2;
		int c = 5;

		int one = (a+b)*c-b;
		int two = (b>c)?a:b;

		Console.WriteLine("{0} and {1}", one, two);
	}
}
