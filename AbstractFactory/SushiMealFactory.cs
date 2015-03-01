using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SushiMealFactory : MealFactory
    {
        public Meal createMeal(string mealType)
        {
            if (mealType == "Osaka")
            {
                return new Osaka();
            }
            if (mealType == "Tokyo")
            {
                return new Tokyo();
            }
            if (mealType == "Yamagata")
            {
                return new Yamagata();
            }

            return null;

        }
    }
}
