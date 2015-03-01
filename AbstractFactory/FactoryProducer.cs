using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryProducer
    {
    
         public MealFactory getMealFactory(String factoryType){

             if (factoryType == "SushiFactory")
             {
                 return new SushiMealFactory();
             }
             if (factoryType == "WrapFactory")
             {
                 return new WrapMealFactory();
             }
             if (factoryType == "WokFactory")
             {
                 return new WokMealFactory();
             }

             return null;

        }
    
    }
}
