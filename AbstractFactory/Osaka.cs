using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Osaka : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Osaka");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Osaka");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Osaka");
        }
    
    }
}
