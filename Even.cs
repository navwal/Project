using System;
class Demo
{
	static void Main()
	{
		Console.WriteLine("Please input the size of the array: ");
		int size = Convert.ToInt32(Console.ReadLine());
		int [] array = new int[size];

		Console.WriteLine("Please input array items: ");
		for ( int i = 0; i < size; i++)
			array[i] = Convert.ToInt32(Console.ReadLine());

		int count = 0;
		for ( int j = 0; j < size; j++)
		{
			if (array[j] % 2 == 0)
				count++;
		}
		Console.WriteLine("Total number of even numbers in array = {0}", count);
	}
}
