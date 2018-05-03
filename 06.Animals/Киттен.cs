
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
    public class Kitten: Animal
    {
		public Kitten(int age, string name, string gender) : base(age, name, gender)
		{
			base.Gender = "Female";

		}

		public string ProduceSound()
		{
			return "meow";
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
