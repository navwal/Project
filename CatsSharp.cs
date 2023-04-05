using System;
public class Cat
{
	//Field name
	public string name;
	//Field color
	public string color;

	public string Name
	{
		//Getter of the property "Name"
		get
		{
			return this.name;
		}
		//Setter of the property "Name"
		set
		{
			this.name = value;
		}
	}
	
	public string Color
	{
		get
		{
			return this.color;
		}
		set
		{
			this.color = value;
		}
	}

	//Default constructor
	public Cat()
	{
		this.name = "Unamed";
		this.color = "gray";
	}

	//Constructor with parameters
	public Cat(string name, string color)
	{
		this.name = name;
		this.color = color;
	}

	//Method SayMiau
	public void SayMiau()
	{
		Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
	}


	public void OldCats()
	{		
		Cat firstCat = new Cat();
		firstCat.Name = "Tony";
		firstCat.SayMiau();

		Cat secondCat = new Cat("Pepy", "red");
		secondCat.SayMiau();
		Console.WriteLine("Cat {0} is {1}.", secondCat.name, secondCat.color);
	}
}
class CatManipulating
{
	/*static void Main()
	{
		Cat myCat = new Cat();
		myCat.name = "Alfred";

		Console.WriteLine("The name of my cat is {0}.", myCat.name);
		myCat.SayMiau();
	}*/
	static void Main()
	{
		Cat uCat = new Cat();

		uCat.OldCats();
		uCat.SayMiau();
		Console.WriteLine("The color of cat {0} is {1}.", uCat.name, uCat.color);

		Cat someCat = new Cat("Johnny", "brown");

		someCat.SayMiau();
		Console.WriteLine("The color of cat {0} is {1}.", someCat.name, someCat.color);
	}
}
