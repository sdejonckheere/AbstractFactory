using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface Meal
    {

        void order();
        void prepare();
        void deliver();
    
    }
}
