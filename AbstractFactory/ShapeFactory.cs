using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {

        public override Color getColor(String color)
        {

            return null;

        }

       public override Shape getShape(String shape)
        {

            if (shape == "Triangle")
            {

                return new Triangle();

            }
           
            if (shape == "Square")
            {

                return new Square();

            }
            
            if (shape == "Rectangle")
            {

                return new Rectangle();

            }

            return null;
        }


      
    }
}
