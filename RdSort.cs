using System.Collections.Generic;
using System;
class Assignment
{
	//Create Sort Method
	public void insertion(int[] array)
	{
		int n = array.Length;
		for (int i = 1; i < n; i++)
		{
			int key = array[i];
			int j = i - 1;
			while (j >= 0 && array[j] > key)
			{
				array[j + 1] = array[j];
				j = j - 1;
			}
			array[j + 1] = key;
		}
	}

	public static void Main()
	{
		//Create random number function
		Random rd = new Random();

		//Create array
		int[] arr = new int[50];

		//Generate rd numbers for array	
		for (int i = 0; i < 50; i++)
		{
			arr[i] = rd.Next(100); //Generates pos. numbers less than 100
		}

		//Display array
		Console.WriteLine("Array");
		for (int i = 0; i < 50; i++)
			Console.Write("{0}, ", arr[i]);
		Console.Write("\n");

		//Sort array using insertion method
		Assignment prgm = new Assignment();
		prgm.insertion(arr);

		//Display sorted array
		Console.WriteLine("New sorted array");
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write("{0}, ", arr[i]);
		}
		Console.Write("\n");
	}
}
