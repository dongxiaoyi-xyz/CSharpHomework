using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square : Shape
    {
        double sideLength { get; set; }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public bool IsLegal()
        {
            return sideLength > 0;
        }

        public void PrintSelf()
        {
            Console.WriteLine($"正方形：边长为{sideLength}");
        }
    }
}
