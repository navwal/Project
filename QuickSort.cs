using System;
class Exam
{
	static int Part(int[] arr, int low, int high)
	{
		int pivot = arr[low];
		int n = high;
		for (int i = high; i > low; i--)
		{
			if (arr[i] > pivot)
			{
				Swap(arr, i, n--);
			}
		}
		Swap(arr, low, n);
		return n;
	}
	static void Swap(int[] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}
	static void Qsort(int[] arr, int low, int high)
	{
		if (low < high)
		{
			int index = Part(arr, low, high);
			Qsort(arr, low, index-1);
			Qsort(arr, index+1, high);
		}
	}
	static void Main()
	{
		//int[] arr = {5, 9, 2, 1, 4, 8, 3, 7, 6};
		Console.WriteLine("Please input the size of your array: ");
		int L = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[L];
		Console.WriteLine("Please input your array, after each number press 'enter': ");
		for (int j = 0; j < L; j++)
			arr[j] = Convert.ToInt32(Console.ReadLine());
		Qsort(arr, 0, L - 1);
		Console.WriteLine("Sorted Arrary: ");
		for (int i = 0; i < L; i++)
			Console.WriteLine(arr[i] + " ");
		Console.WriteLine();
	}
}
