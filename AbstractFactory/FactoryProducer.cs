using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryProducer
    {

        public static AbstractFactory getFactory(String choice)
        {

            if (choice == "Shape")
            {

                return new ShapeFactory();

            }
            if (choice == "Color")
            {

                return new ColorFactory();

            }

            return null;

        }
    
    }
}
