using System.IO;
using System;
class Assignment
{
	public static void Main()
	{
		Console.WriteLine("Please input string: ");
		string str = Console.ReadLine();
		string filename = "User.txt";
		if(!File.Exists(filename))
		{
			File.Create(filename);
		}
		else
		{
			File.WriteAllText(filename, str);
			Console.WriteLine(File.ReadAllText(filename));
		}
		int count = 0;
		foreach(char ch in str)
		{
			if(char.IsLetter(ch))
				count++;
		}
		Console.WriteLine("Total number of letters in file: " + count);
	}
}

