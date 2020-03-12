using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle : Shape
    {
        double firstSide { get; set; } 
        double secondSide { get; set; }
        double thirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public double GetArea()
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        public bool IsLegal()
        {
            return firstSide + secondSide > thirdSide
                && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide
                && firstSide > 0 && secondSide > 0 && thirdSide > 0;
        }

        public void PrintSelf()
        {
            Console.WriteLine($"三角形：三边长分别为{firstSide}、{secondSide}、{thirdSide}");
        }
    }
}
