using System;
class mergersort
{
	public static int[] SortArray(int[] array, int left, int right)
	{
		if (left < right)
		{
			int middle = left + (right - left) / 2;
			SortArray(array, left, middle);
			SortArray(array, middle + 1, right);
		}
		return array;
	}

	public static void MergeArray(int[] array, int left, int middle, int right)
	{
		var leftArrayLength = middle - left +1;
		var rightArrayLength = right - middle;
		var leftTempArray = new int[leftArrayLength];
		var rightTempArray = new int[rightArrayLength];
		int i, j;
		for (i = 0; i < leftArrayLength; ++i)
			leftTempArray[i] = array [left + i];
		for (j = 0; j < rightArrayLength; ++j)
			rightTempArray[j] = array[middle + 1 + j];
		i = 0;
		j = 0;
		int k = left;
		while (i < leftArrayLength && j < rightArrayLength)
		{
			if (leftTempArray[i] <= rightTempArray[j])
			{
				array[k++] = leftTempArray[i++];
			}
			else
			{
				array[k++] = rightTempArray[j++];
			}
		}
		while (i < leftArrayLength)
		{
			array[k++] = leftTempArray[i++];
		}
		while (j < rightArrayLength)
		{
			array[k++] = rightTempArray[j++];
		}
	}
	static void Main()
	{
		int[] test = {9, 7, 6, 4, 5, 8, 2, 3, 1};
		int[] output = SortArray(test, 0, 8);
		for (int i = 0; i < test.Length; i++)
			Console.WriteLine(output[i]);
	}
}
