using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double areaSum = 0;
            Random rd = new Random();
            while (i < 10)
            {
                Shape aShape = Factory.CreateShape(rd.Next());
                if (aShape.IsLegal())
                {
                    i++;
                    Console.WriteLine($"第{i}个形状对象为");
                    aShape.PrintSelf();
                    areaSum += aShape.GetArea();
                }
            }
            Console.WriteLine($"十个形状对象的总面积为{areaSum}");
        }
    }
}
