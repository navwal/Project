using System;
class Assignment
{
	static int Coin(int c)
	{
		int count = 0;
		while (c > 0)
		{
			if (c >= 25)
			{
				c = c - 25;
				count++;
			}
			else if (25 > c && c >= 10)
			{
				c = c - 10;
				count++;
			}
			else if (10 > c && c >= 5)
			{
				c = c - 5;
				count++;
			}
			else
			{
				c = c - 2;
				count++;
			}
		}
		if (c == 0)
			return count;
		else
			return -1;
	}

	static void Main()
	{
		Console.WriteLine("Please enter a cent value less than $1: ");
		int money = Convert.ToInt32(Console.ReadLine());
		int change = Coin(money);
		if (change > 0)
			Console.WriteLine("Total coin count: " + change);
		else
			Console.WriteLine("Your money could not be evenly divided into change");
	}
}
