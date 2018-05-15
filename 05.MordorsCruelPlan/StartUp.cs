using System;

namespace _05.MordorsCruelPlan
{
    class StartUp
    {
        static void Main()
        {
			var foods = Console.ReadLine();
			string result = MoodFactory.CreateMood(FoodFactory.CreateFood(foods));
			Console.WriteLine(result);
        }
    }
}
