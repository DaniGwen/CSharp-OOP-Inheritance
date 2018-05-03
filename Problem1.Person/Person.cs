using System;
using System.Collections.Generic;
using System.Text;


public class Person
{

	public virtual string Name
	{
		get { return this.Name; }
		set
		{
			if (Name.Length < 3)
			{
				throw new Exception("Name's length should not be less than 3 symbols!");
			}
			else
			{
				Name = value;
			}
		}
	}

	public virtual int Age
	{
		get { return this.Age; }
		set
		{
			if (Age < 0)
			{
				throw new Exception("Age must be positive!");
			}
			else
			{
				this.Age = value;
			}
		}
	}

	public Person(string name, int age)
	{
		this.Name = name;
		this.Age = age;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format("Name {0}, Age: {1}", this.Name, this.Age));
		return stringBuilder.ToString();
	}
}

