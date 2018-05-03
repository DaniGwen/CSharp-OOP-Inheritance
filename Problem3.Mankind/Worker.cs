using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3.Mankind
{
	public class Worker : Human
	{
		private const int WorkDaysperWeek = 5;

		public Worker(string firstName, string lastName, decimal weekSalary, int workHours) : base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHours;
		}

		public decimal WeekSalary
		{
			get { return weekSalary; }
			set
			{
				if (value <= 10)
				{
					throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
				}
				weekSalary = value;
			}
		}

		public int WorkHoursPerDay
		{
			get { return workHoursPerday; }
			set
			{
				if (value < 1 || value > 12)
				{
					throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
				}
				workHoursPerday = value;
			}
		}

		private decimal weekSalary;
		private int workHoursPerday;

		public decimal moneyPerHour => WeekSalary / (WorkDaysperWeek * WorkHoursPerDay);

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder(base.ToString());

			builder.AppendLine($"Week Salary:  {this.WeekSalary:f2}")
				.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
				.AppendLine($"Salary per hour: {moneyPerHour:f2}");

			var result = builder.ToString();
			return result;
		}
	}
}
