using System;
class Grade
{
	static void Main()
	{
		Console.WriteLine("Input Raw Score");
		double grade = Convert.ToDouble(Console.ReadLine());
		
		if (grade <= 1000 && grade >= 930)
			Console.WriteLine("You've received an A");
		else if (grade >= 820 && grade < 930)
			Console.WriteLine("You've received a B");
		else if (grade >= 710 && grade < 820)
			Console.WriteLine("You've received a C");
		else if (grade >= 600 && grade < 710)
			Console.WriteLine("You've received a D");
		else if (grade >= 0 && grade < 600)
			Console.WriteLine("You've received an F");
		else
			Console.WriteLine("INVALID INPUT! Please Type a value between 0 and 1000");
	}
}
