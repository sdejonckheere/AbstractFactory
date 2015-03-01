using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Athens : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Athens");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Athens");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Athens");
        }
    
    }
}
