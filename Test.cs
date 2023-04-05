// Array.BinarySearch(Array, Object)
// Method
using System;
class Test
{
	//Main Method
	public static void Main()
	{
		int [] arr = new int[7] {1, 5, 7, 4, 6, 2, 3};
		System.Array.Sort(arr);
		Console.WriteLine("\nType an integer to search: ");
		int s = Convert.ToInt32(Console.ReadLine());
		search(arr, s);
		Console.Write("The elements fo the Array are: ");
		display(arr);
	}
	static void search(int[] arr2, int k)
	{
		int res = System.Array.BinarySearch(arr2, k);
		if (res < 0)
		{
			Console.WriteLine("\nThe element to search for " + "({0}) is not found.", k);
		}
		else
		{
			Console.WriteLine("The element to search for " + "({0}) is at index {1}.", k, res);
		}
	}
	static void display(int[] arr1)
	{
		foreach(int i in arr1)
			Console.Write(i + " ");
	}
}	
