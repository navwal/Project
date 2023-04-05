using System;
class Demo
{
	public static int binarySearch(int[] arr, int x)
	{
		int low = 0, high = arr.Length - 1;
		while (low <= high)
		{
			int mid = (low + high) / 2;
			if (x == arr[mid])
			{
				return mid;
			}
			else if (x < arr[mid])
			{
				high = mid - 1;
			}
			else
			{
				low = mid + 1;
			}
		}
		return -1;
	}

	public static void Main()
	{
		Random rd = new Random();
		int[] array = new int[20];
		for (int i = 0; i < array.Length; i++)
		{
			int number = rd.Next(1, 30);
			array[i] = number;
		}
		Console.WriteLine("Please input a number to search:");
		int target = Convert.ToInt32(Console.ReadLine());
		if(binarySearch(array, target)  >= 0)
		{
			Console.WriteLine("found at [{0}]", binarySearch(array, target));
		}
		else
			Console.WriteLine("{0} Not Found", target);
	}
}
