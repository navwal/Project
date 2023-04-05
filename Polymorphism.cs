using System;
namespace Polymorphism
{
	public abstract class Car
	{
		public abstract void Speed();
		public int speed;
		public string make;
		public string model;
		public string year;
		public string build;
		public void speedLimit(int spd)
		{
			if(spd >= 120)
				Console.WriteLine("Please slow down!");
		}
	}

	public class Maruti : Car
	{
		public override void Speed()
		{
			Console.WriteLine("The Maruti goes 60 km/hr");
		}
	}

	public class Alto : Car
	{
		public override void Speed()
		{
			Console.WriteLine("The Alto goes 70 km/hr");
		}
	}

	public class Brezza : Car
	{
		public override void Speed()
		{
			Console.WriteLine("The Brezza goes 80 km/hr");
		}
	}

	public class Test
	{
		public static void Main()
		{
			Maruti car1 = new Maruti();
			car1.make = "Suzuki";
			car1.model = "Maruti";
			car1.year = "2001";
			car1.build = "Compact car";
			car1.speed = 60;

			Alto car2 = new Alto();
			car2.make = "Suzuki";
			car2.model = "Alto";
			car2.year = "2023";
			car2.build = "Compact car";
			car2.speed = 70;

			Brezza car3 = new Brezza();
			car3.make = "Vitara";
			car3.model = "Brezza";
			car3.year = "2022";
			car3.build = "SUV";
			car3.speed = 80;

			car1.Speed();
			car1.speedLimit(car1.speed);
			Console.WriteLine("\nThe make of the car is: {0}\nThe model of the car is: {1}\nThe year the car was made: {2}\nThe car's build: {3}\n", car1.make, car1.model, car1.year, car1.build);

			car2.Speed();
			car2.speedLimit(car2.speed);
			Console.WriteLine("\nThe make of the car is: {0}\nThe model of the car is: {1}\nThe year the car was made: {2}\nThe car's build: {3}\n", car2.make, car2.model, car2.year, car2.build);

			car3.Speed();
			car2.speedLimit(car3.speed);
			Console.WriteLine("\nThe make of the car is: {0}\nThe model of the car is: {1}\nThe year the car was made: {2}\nThe car's build: {3}\n", car3.make, car3.model, car3.year, car3.build);
		}
	}
}
