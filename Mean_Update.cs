class Mean
{
	static void Main(string[] args)
	{
		//user input
		System.Console.WriteLine("a= ");
		decimal a = System.Convert.ToDecimal(System.Console.ReadLine());
		System.Console.WriteLine("b= ");
		decimal b = System.Convert.ToDecimal(System.Console.ReadLine());
		System.Console.WriteLine("c= ");
		decimal c = System.Convert.ToDecimal(System.Console.ReadLine());

		//Finding avg. with user inputs
		decimal sum = (a+b+c)/3;
		System.Console.WriteLine(sum);
	}
}
/*user inputs can only be strings. 
int can be used only when it is specified it will be a #. 
"Convert.ToInt32" tells the code the user input will be a #
"Console.ReadLine()" Reads user input*/
