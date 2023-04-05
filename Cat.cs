public class Cat
{
	public string name;
	public string color;
	public void sound()
	{
		System.Console.WriteLine("The {0} cat says MIAUUUUUUU!", name);
	}
}
public class demo
{
	static void Main()
	{
		Cat cat1 = new Cat();
		Cat cat2 = new Cat();

		cat1.name = "Unamed";
		cat1.color = "Gray";

		cat2.name = "Johnny";
		cat2.color = "Brown";

		cat1.sound();
		System.Console.WriteLine("The {0} cat is {1}.", cat1.name, cat1.color);
		cat2.sound();
		System.Console.WriteLine("{0} is {1}.", cat2.name, cat2.color);
	}
}
