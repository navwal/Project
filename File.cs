using System.IO;
using System;
class Assignment
{
	public static void Main()
	{
		string f1 = "1.txt";
		string f2 = "2.txt";

		//Create File
		File.Create(f1).Close();
		
		//For Loop even numbers
		for(int i = 0; i < 101; i++)
		{
			if( i % 2 == 0)
			{
				File.AppendAllText(f1, Convert.ToString(i) + Environment.NewLine);
			}
		}
		
		//Create 2.txt file
		//Copy 1 -> 2
		File.Copy(f1, f2); //This method creates the 2nd file. 

		//Delete 1.txt
		File.Delete(f1);

		//Print 2.txt
		Console.WriteLine(File.ReadAllText(f2));
		
		//Close
	}
}
