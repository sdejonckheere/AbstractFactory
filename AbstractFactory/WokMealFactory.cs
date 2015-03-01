using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WokMealFactory : MealFactory
    {
        public Meal createMeal(string mealType)
        {
            if (mealType == "Bangkok")
            {
                return new Bangkok();
            }
            if (mealType == "Yala")
            {
                return new Yala();
            }
            if (mealType == "Lampang")
            {
                return new Lampang();
            }

            return null;
        }
    }
}
