using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem3.Mankind
{
	public class Student : Human
	{
		private const string facultyPattern = @"^[A-Za-z\d]{5,10}$";

		public Student(string firstName, string lastName, string facultyNumber)
			: base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		private string facultyNumber;
		public string FacultyNumber
		{
			get
			{ return facultyNumber ; }
			set
			{
				if (!Regex.IsMatch(value, facultyPattern))
				{
					throw new ArgumentException($"Invalid faculty number!");
				}
				facultyNumber = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder(base.ToString());

			builder.AppendLine($"Faculty number: {this.FacultyNumber}");

			var result = builder.ToString();

			return result;
		}
	}
}
