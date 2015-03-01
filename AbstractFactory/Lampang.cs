using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Lampang : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Lampang");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Lampang");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Lampang");
        }
    
    }
}
