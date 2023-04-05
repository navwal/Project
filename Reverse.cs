using System;
class Reverse
{
	public static void Main()
	{
		Console.WriteLine("Please input a String: ");
		string str1 = Console.ReadLine();
		char[] str = str1.ToCharArray();

		//approach 1
		Array.Reverse(str);
		string str2 = new String(str);
		Console.WriteLine("Your input reversed: " + str2);

		//approach 2
		string str3 = String.Empty;
		for (int i = str.Length - 1; i >= 0; i--)
			str3 += str[i];
		Console.WriteLine("Your original input: " + str3);
	}
}
