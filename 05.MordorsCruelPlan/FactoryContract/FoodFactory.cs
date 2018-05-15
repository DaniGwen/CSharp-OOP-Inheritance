using _05.MordorsCruelPlan.FoodContacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MordorsCruelPlan
{
   public abstract class FoodFactory
    {
		public static List<IFood> CreateFood(string foods)
		{
			var splitFood = foods.Split(" ");
			var listFoods = new List<IFood>();

			foreach (var food in splitFood)
			{
				switch (food.ToLower())
				{
					case "cram":
						var cram = new Cram();
						listFoods.Add(cram);
						break;
					case "melon":
						var melon = new Melon();
						listFoods.Add(melon );
						break;
					case "lembas":
						var lembas = new Lembas();
						listFoods.Add(lembas);
						break;
					case "apple":
						var apple = new Apple();
						listFoods.Add(apple);
						break;
					case "honeycake":
						var honeyCake = new HoneyCake();
						listFoods.Add(honeyCake);
						break;
					case "mushrooms":
						var mushrooms = new MushRooms();
						listFoods.Add(mushrooms);
						break;
					default:
						var everythingElse = new EverythingElse();
						listFoods.Add(everythingElse);
						break;
				}
			}

			return listFoods;
		}
    }
}
