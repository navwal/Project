using System;
public class Assignment
{
	public static int[] Merge(int[] arrone, int[] arrtwo)
	{
		var Arr = new int[arrone.Length + arrtwo.Length];
		int i = 0;
		int j = 0;
		int k = 0;
		while (i < arrone.Length && j < arrtwo.Length)
		{
			if (arrone[i] <= arrtwo[j])
				Arr[k++] = arrone[i++];
			else
				Arr[k++] = arrtwo[j++];
		}
		while (i < arrone.Length)
			Arr[k++] = arrone[i++];
		while (j < arrtwo.Length)
			Arr[k++] = arrtwo[j++];
		return Arr;
	}

	public static int[] InputOne(int szone)
	{
		int[] aone = new int[szone];
		Console.WriteLine("Please input integers in ascending order, press 'enter' after each integer");
		for (int i = 0; i < aone.Length; i++)
			aone[i] = Convert.ToInt32(Console.ReadLine());
		return aone;
	}

	public static int[] InputTwo(int sztwo)
	{
		int[] atwo = new int[sztwo];
		Console.WriteLine("Please input integers in ascending order, press 'enter' after each integer");
		for (int i = 0; i < atwo.Length; i++)
			atwo[i] = Convert.ToInt32(Console.ReadLine());
		return atwo;
	}

	public static void Main()
	{
		Console.WriteLine("Please input size of first array: ");
		int FirstSz = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please input size of second array: ");
		int SecondSz = Convert.ToInt32(Console.ReadLine());
		int[] one = InputOne(FirstSz);
		int[] two = InputTwo(SecondSz);
		int[] output = Merge(one, two);
		Console.WriteLine("Merged Array Result: ");
		for (int i = 0; i < output.Length; i++)
			Console.WriteLine(output[i]);
	}
}
