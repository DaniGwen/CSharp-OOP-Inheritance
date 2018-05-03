using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Animals
{
	public class Tomcat : Animal
	{
		public Tomcat(int age, string name, string gender) : base(age, name, gender)
		{
			base.Gender = "Male";
		}

		public string ProduceSound()
		{
			return "MEOW";
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
