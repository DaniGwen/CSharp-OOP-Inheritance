using System;
using System.Collections.Generic;
using System.Text;


public class StackOfStrings
{
	private List<string> data = new List<string>();

	public void Push(string item)
	{
		data.Add(item);
	}

	public string Pop()
	{
		var element = data[data.Count - 1];
		data.RemoveAt(data.Count - 1);
		return element;
	}

	public string Peek()
	{
		var element = data[data.Count - 1];
		return element;
	}

	public bool IsEmpty()
	{
		if (data.Count == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

