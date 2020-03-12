using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Rectangle : Shape
    {
        double length { get; set; }
        double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public bool IsLegal()
        {
            return length > 0 && width > 0;
        }

        public void PrintSelf() 
        {
            Console.WriteLine($"长方形：长为{length},宽为{width}");
        }
    }
}
