using System;
class sum
{
	static void Main()
	{
		Console.WriteLine("Input First Number");
		double a = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Input Second Number");
		double b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Input Third Number");
		double c = Convert.ToDouble(Console.ReadLine());

		double sum = a*a + b*b + c*c;
		Console.WriteLine(a + "^2" + "+" + b + "^2" + "+" + c + "^2 =" + sum);
	}
}
