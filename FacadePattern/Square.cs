﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
