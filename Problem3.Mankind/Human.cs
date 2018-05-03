using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3.Mankind
{
	public class Human
	{
		private const int MinLenghtFirstName = 4;
		private const int MinLenghtLastName = 3;

		public Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		private string firstName;
		private string lastName;

		public string FirstName
		{
			get { return firstName; }
			set
			{
				ValidateName(value, nameof(firstName), MinLenghtFirstName);
				firstName = value;
			}
		}

		public string LastName
		{
			get { return lastName; }
			set
			{
				ValidateName(value, nameof(lastName), MinLenghtLastName );
				lastName = value;
			}
		}


		private static void ValidateName(string value, string type, int minLenght)
		{
			if (char.IsLower(value[0]))
			{
				throw new ArgumentException($"Expected upper case letter! Argument: {type}");
			}
			if (value.Length < minLenght)
			{
				throw new ArgumentException($"Expected length at least {minLenght} symbols! Argument: firstName");
			}
		}

		public override string ToString()
		{

			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"First Name: {this.FirstName}")
				.AppendLine($"Last Name: {this.LastName}");

			string result = builder.ToString();
			return result;
		}
	}
}
