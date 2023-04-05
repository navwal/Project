class Exercise
{
	static void Main()
	{
		for(int i = 2; i < 102; i++)
		{
			int val = i % 2 == 1 ? i * -1 : i;
			System.Console.WriteLine(val);
		}
	}
}