﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Square : Shape
    {
        public void draw()
        {
            System.Diagnostics.Debug.WriteLine("Hoi ik ben een Square");
        }
    }
}
