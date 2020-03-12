using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Factory
    {
        public static Shape CreateShape(int seed)
        {
            Random rd = new Random(seed);
            int choice = rd.Next();
            choice %= 3;
            switch (choice) 
            { 
                case 0:
                    return new Rectangle(rd.NextDouble(), rd.NextDouble());
                case 1:
                    return new Square(rd.NextDouble());
                case 2:
                    return new Triangle(rd.NextDouble(), rd.NextDouble(), rd.NextDouble());
                default:
                    return new Rectangle(rd.NextDouble(),rd.NextDouble());
            }
        }
    }
}
