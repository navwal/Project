using System;
class Array
{
	static void Main()
	{
		Random n = new Random();
		int size = n.Next(5, 20);
		Console.WriteLine("The index size of the array is {0}", size);
		Console.WriteLine("Type an integer");
		int[] arr = new int[size];
		for (int i = 0; i < size; i++)
		{
			int j = n.Next(0, 99);
			arr[i] = j;
		}
		int num = Convert.ToInt32(Console.ReadLine());
		search(arr, num);
		Console.Write("The elements to the Array are: ");
		display(arr);
		Console.WriteLine("\n");
	}
	static void search(int [] arr1, int a)
	{
		int res = System.Array.BinarySearch(arr1, a);
		if (res < 0)
		{
			Console.WriteLine("\n-1: " + " Integer not found in Array");
		}
		else
		{
			Console.WriteLine("The element to search for " + "({0}) is at index {1}.", a, res);
		}
	}
	static void display(int[] arr2)
	{
		foreach(int i in arr2)
			Console.Write(i + " ");
	}
}
