using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
	public class Animal
	{
		public Animal()
		{

		}

		public Animal(int age,string name,string gender) : this()
		{
			this.Age = age;
			this.Name = name;
			this.Gender = gender;
		}

		private string gender;
		private string name;
		private int age;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string ProduceSound()
		{ 
			return "Sound!";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{GetType().Name}")
				.AppendLine($"{this.Name} {this.Age} {this.Gender}");

			var result = sb.ToString();
			return result;
		}
	}
}
