using System;
using System.IO;
class even
{
	public static void Main()
	{
		string filename = "Even.txt";
		File.Create(filename).Close();
		for(int i = 0; i < 101; i++)
		{
			if(i % 2 == 0)
				File.AppendAllText(filename, Convert.ToString(i) + Environment.NewLine);
		}
	}
}
