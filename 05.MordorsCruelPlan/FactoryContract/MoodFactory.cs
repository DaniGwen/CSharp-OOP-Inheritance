using _05.MordorsCruelPlan.FoodContacts;
using _05.MordorsCruelPlan.MoodContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MordorsCruelPlan
{
	public static class MoodFactory
	{
		public static string CreateMood(List<IFood> foodObjects)
		{
			int happiness = 0;
			IMood mood;

			foreach (var food in foodObjects)
			{
				happiness += food.HappinessPoints;
			}

			if (happiness < -5)
			{
				var angry = new Angry();
				mood = angry;
			}
			else if (happiness >= -5 && happiness <= 0)
			{
				var sad = new Sad();
				mood = sad;
			}
			else if (happiness >= 1 && happiness < 15)
			{
				var happy = new Happy();
				mood = happy;
			}
			else
			{
				var javaScript = new JavaScript();
				mood = javaScript;
			}

			var stringBuilder = new StringBuilder();

			stringBuilder.AppendLine(happiness.ToString())
				.AppendLine(mood.ToString());

			return stringBuilder.ToString().TrimEnd();
		}
	}
}
