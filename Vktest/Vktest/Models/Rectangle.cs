using System;
using System.Collections.Generic;
using System.Text;

namespace Vktest.Models
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }
}
