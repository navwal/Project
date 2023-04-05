using System;
class Integer
{
	static void Main()
	{
		Console.WriteLine("Input any number");
		double num = Convert.ToDouble(Console.ReadLine());
		int round = Convert.ToInt32(num);
		Console.WriteLine(num + " Rounded = " + round);
	}
}
