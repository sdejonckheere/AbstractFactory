using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Bangkok : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Bangkok");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Bangkok");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Bangkok");
        }
    
    }
}
