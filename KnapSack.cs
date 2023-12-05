using System;
using System.Collections.Generic;
public class Jewel
{
	public int Weight {get; set;}
	public int Value {get; set;}
	
	public static int KnapSack(int bagCapacity, List<> jewels)
	{
		var itemCount = jewels.Count;
		int[,] matrix = new int[itemCount + 1, bagCapacity + 1];

		for (int i = 0; i <= itemCount; i++)
		{
			for (int w = 0; w <= bagCapacity; w++)
			{
				if (i == 0 || w == 0)
				{
					matrix[i, w] = 0;
					continue;
				}

				var currentJewelIndex = i -1;
				var currentJewel = jewels[currentJewelIndex];
				
				if (currentJewel.Weight <= w)
				{
					matrix[i,w] = Math.Max(currentJewel.Value + matrix[i -1, w-currentJewel.Weight], matrix[i-1, w]);
				}
				else
					matrix[i,w] = matrix[i-1, w];
			}
		}
		return matrix[itemCount, bagCapacity];
	}

	static void Main()
	{
		var items = new List<> {new Jewel {Value = 120, Weight = 10}, new Jewel {Value = 100, Weight = 20}, new Jewel {Value = 500, Weight = 30},};
		Console.WriteLine(KnapSack(50, items));
	}
}
