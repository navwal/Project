using System;
class Assignment
{
	static decimal Fact(decimal n)
	{
		decimal count = 0;
		for (int i = 1; i <= n; i++)
		{
			if (i == 1)
				count = i;
			else
				count = count*i;
		}
		return count;
	}
	static void Main()
	{
		Console.WriteLine("Please enter an integer: ");
		decimal input = Convert.ToDecimal(Console.ReadLine());
		Console.WriteLine(input + "! = ");
		Console.WriteLine(Fact(input));
	}
}
