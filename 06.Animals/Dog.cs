using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
    public class Dog: Animal
    {
		public Dog(int age, string name, string gender) : base(age, name, gender)
		{

		}

		public string ProduceSound() 
		{
			return "Woof";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder(base.ToString());
			sb.AppendLine(ProduceSound());
			var result = sb.ToString().TrimEnd();
			return result;
		}
	}
}
