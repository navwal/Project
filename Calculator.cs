using System;
class Calculator
{
	static void Main()
	{
		//add text
		Console.WriteLine("Input number for Integer 1");
		decimal one = Convert.ToDecimal(Console.ReadLine());

		//input for integer 2
		Console.WriteLine("Input number for Integer 2");
		decimal two = Convert.ToDecimal(Console.ReadLine());

		//input operator
		Console.WriteLine("Input operator for calculation, (+, -, * or /)");
		string op = Console.ReadLine();

		//establish variables
		decimal sum = 0;
		decimal divsum = 0;

		//addition
		if (op == "+")
		{	
			sum = one + two;
			Console.WriteLine("{0}" + "{1}" + "{2} =  {3}", one, op, two, sum);
		}
		//subtraction
		else if (op == "-")
		{
			sum = one - two;
			Console.WriteLine("{0}" + "{1}" + "{2} =  {3}", one, op, two, sum);
		}
		//multiplation
		else if (op == "*")
		{
			sum = one * two;
			Console.WriteLine("{0}" + "{1}" + "{2} =  {3}", one, op, two, sum);
		}
		//Division
		else if (op == "/")
			//if they try to divide by 0
			if (two == 0)
				Console.WriteLine("Cannot divide by 0");
			else
		{
			divsum = Convert.ToDecimal(one / two);
			Console.WriteLine("{0}" + "{1}" + "{2} =  {3}", one, op, two, divsum);
		}
		//don't think this will ever happen, but it is here just in case
		else 
			Console.WriteLine("Invalid operator! Please type '+, -, * or /'");
	}
}
