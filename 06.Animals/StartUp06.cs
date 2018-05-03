using System;
using System.Collections.Generic;

namespace _06.Animals
{
	class StartUp06
	{
		static void Main()
		{
			string input;
			int counter = 0;
			List<Animal> animals = new List<Animal>();

			while ((input = Console.ReadLine()) != "Beast!")
			{
				var detailsInput = Console.ReadLine().Split();

				var name = detailsInput[0];
				var age = int.Parse(detailsInput[1]);
				var gender = detailsInput[2];

				switch (input)
				{
					case "Dog":
						animals.Add(new Dog(age, name, gender));
						break;
					case "Cat":
						animals.Add(new Cat(age, name, gender));
						break;
					case "frog":
						animals.Add(new Frog(age, name, gender));
						break;
					case "Kittens":
						animals.Add(new Kitten(age, name, gender));
						break;
					case "Tomcat":
						animals.Add(new Tomcat(age, name, gender));
						break;
					default:
						throw new ArgumentException();
				}
				counter++;
			}

			foreach (var animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
	}
}
