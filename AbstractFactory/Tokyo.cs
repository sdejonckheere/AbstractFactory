using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Tokyo : Meal
    {

        public void order()
        {
            System.Diagnostics.Debug.WriteLine("Ordering Tokyo");
        }

        public void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Tokyo");
        }

        public void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Tokyo");
        }
    }
}
