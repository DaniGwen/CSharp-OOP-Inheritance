using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
	public class Frog : Animal
	{
		public Frog(int age, string name, string gender) : base(age, name, gender)
		{

		}

		public string ProduceSound()
		{
			return "Ribbit";
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
