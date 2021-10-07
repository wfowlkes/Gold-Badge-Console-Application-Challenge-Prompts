using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneRepository
{
    public class Menu
    {
      
        public Menu () { }

        public Menu(string mealNumber, string mealName, string description, string ingredients, string price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
           
        }
        public string MealNumber { get; set; }

        public string MealName { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public string Price { get; set; }

    }
}
