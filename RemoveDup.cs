using System;
class Leet
{
	static int[] ArrBuilder()
	{
		Console.WriteLine("Please enter array Length: ");
		int L = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[L];
		Console.WriteLine("Please type the numbers of your array in acsending order and press 'enter' after each number: ");
		for (int j = 0; j < L; j++)
			arr[j] = Convert.ToInt32(Console.ReadLine());
		return arr;
	}
	static int RemoveDuplicates(int[] nums)
	{
		int i = 1;
		foreach (int n in nums)
		{
			if (nums[i - 1] != n)
				nums[i++] = n;
		}
		return i;
	}
	static void Main()
	{
		int output = RemoveDuplicates(ArrBuilder());
		Console.WriteLine("Number of unique characters in your array: " + output);
	}
}
