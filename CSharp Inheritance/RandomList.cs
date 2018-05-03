using System;
using System.Collections.Generic;
using System.Text;

public class RandomList  : List<string>
{
		
	public string RandomString(List<string> list)
	{
		string element = "";
		if (this.Count > 0)
		{
			Random random = new Random(list.Count - 1);
			element = random.ToString();
			list.Remove(random.ToString());
		}
		return element;
	}
}

