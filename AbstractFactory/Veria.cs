using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Veria : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Veria");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Veria");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Veria");
        }
    
    }
}
