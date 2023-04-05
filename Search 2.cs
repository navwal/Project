using System;
class Assignment
{
	public static int Linear_search(int[] arr, int target)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == target)
				return i;
		}
		return -1;
	}

	public static void Main()
	{
		int[] array = {3, 5, 1, 4, 2};
		Console.WriteLine("Please enter a number to search: ");
		int target = Convert.ToInt32(Console.ReadLine());
		if (Linear_search(array, target) >= 0)
			Console.WriteLine("Found at [{0}]. ", Linear_search(array, target));
		else
			Console.WriteLine("Not Found.");
	}
}	
			
