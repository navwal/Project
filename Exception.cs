using System;
class demo
{
	static void Main()
	{
		//create an int array
		int[] arr = new int[5];

		//user input array index
		Console.WriteLine("Please input 5 numbers: ");
		for (int i = 0; i < 5; i++)
			arr[i] = Convert.ToInt32(Console.ReadLine());

		//with exception handling
		try 
		{
			for (int i = 0; i <= 5; i++)
				Console.WriteLine(arr[i]);
		}
		catch(IndexOutOfRangeException)
		{
			Console.WriteLine("Trying to print too many items. Press any key to continue... ");
			Console.ReadKey();
		}

		//without exception handling
		for (int i = 0; i < 5; i++)
			Console.WriteLine(arr[i]);
	}
}
