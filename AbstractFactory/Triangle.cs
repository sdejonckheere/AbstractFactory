﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Triangle : Shape
    {
        public void draw()
        {
            System.Diagnostics.Debug.WriteLine("Hallo ik ben een driehoek");
        }
    }
}
