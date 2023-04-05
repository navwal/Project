using System;
public class Cat
{
	//Field name
	public string name;
	//Field color
	public string color;

	public string name
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
		//Getter of the property "Color"
		get
		{
			return this.color;
		}
		//Setter of the property "Color"
		set 
		{
			this.color = value;
		}
	}
	public Cat()
	{
		this.name = "Unnamed";
		this.color = "gray";
	}
	
	//Constructor with parameters
	public Cat(string name, string color)
	{
		this.name = name;
		this.color = color;
	}

	//Method Say Meow
	public void SayMeow()
	{
		Console.WriteLine("The {0} {1} cat said meow!", color, name);
	}
}
