using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {

        public override Shape getShape(String shape)
        {
            return null;
        }

        public override Color getColor(String color)
        {
            if (color == "Blue")
            {
                return new Blue();
            }

            if (color == "Red")
            {
                return new Red();
            }

            if (color == "Green")
            {
                return new Green();
                
            }

            return null;

        }
       
    }
}
