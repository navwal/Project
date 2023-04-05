using System;
class Array
{
	static void Main()
	{
		Console.WriteLine("Insert 5 integers: ");
		int[] arr = new int[5];
		/*arr[0] = Convert.ToInt32(Console.ReadLine());
		arr[1] = Convert.ToInt32(Console.ReadLine());
		arr[2] = Convert.ToInt32(Console.ReadLine());
		arr[3] = Convert.ToInt32(Console.ReadLine());
		arr[4] = Convert.ToInt32(Console.ReadLine());*/
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Type Integer: ");
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		int sum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
		Console.WriteLine("the sum of the array is: {0}", sum);
	}
}
