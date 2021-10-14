﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
