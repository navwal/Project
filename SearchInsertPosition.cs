using System;
class LeetCode
{
	static int Search(int[] nums, int target)
	{
		int left = 0, right = nums.Length - 1, mid;
		while (left <= right)
		{
			mid = (left + right)/2;
			if (nums[mid] < target)
				left = mid + 1;
			else if (nums[mid] > target)
				right = mid - 1;
			else
				return mid;
		}
		return left;
	}

	static void Main()
	{
		int[] input = {1, 3, 5, 6};
		int t = 5;
		int output = Search(input, t);
		Console.WriteLine("Output: " + output);
	}
}
