using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.BookShop
{
	public class Book
	{
		public Book(string author, string title, decimal price)
		{
			this.Autor = author;
			this.Title = title;
			this.Price = price;
		}

		private string title;
		private string autor;
		private decimal price;

		public string Title
		{
			get { return this.title; }
			set
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("Title not valid!");
				}
				this.title = value;
			}
		}

		public string Autor
		{
			get { return this.autor ; }
			set
			{
				string[] autorNames = value.Split();
				if (autorNames.Length == 2 && char.IsDigit(autorNames[1][0]))
				{
					throw new ArgumentException("Autor not valid!");
				}
				this.autor = value;
			}
		}

		public virtual decimal Price
		{
			get { return this.price; }
			set
			{
				if (value <= 0)
				{
					throw new Exception("Price not valid!");
				}
				this.price = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"Type: {this.GetType().Name}")
				.AppendLine($"Title: {this.Title}")
				.AppendLine($"Author: {this.Autor}")
				.AppendLine($"Price: {this.Price:f2}");

			string result = builder.ToString().TrimEnd();
			return result;
		}
	}
}
