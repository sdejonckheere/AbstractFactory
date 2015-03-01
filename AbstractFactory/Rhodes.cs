using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Rhodes : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Rhodes");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Rhodes");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Rhodes");
        }
    
    }
}
