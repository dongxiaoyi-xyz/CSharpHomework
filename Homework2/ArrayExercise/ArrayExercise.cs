using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class ArrayExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组元素个数：");
            int length = Int32.Parse(Console.ReadLine());
            if (length <= 0)//因为接下来要计算数组元素的最大值，最小值，平均值，总和，所以输入的数组元素应该为正数。
            {
                Console.WriteLine("数组元素个数应为正数");
            }
            else
            {
                int[] array = new int[length];
                for(int i = 0; i < length; i++)
                {
                    Console.WriteLine($"输入第{i+1}个数组元素");
                    array[i] = Int32.Parse(Console.ReadLine());
                }
                int max, min, average, sum;
                CalcArray(array, out max, out min, out average, out sum);
                Console.WriteLine($"数组的最大值为{max}");
                Console.WriteLine($"数组的最小值为{min}");
                Console.WriteLine($"数组的平均值为{average}");
                Console.WriteLine($"所有数组元素的和为{sum}");
            }
        }

        //计算数组元素的最大值，最小值，平均值，总和。
        static void CalcArray(int[] array,out int max,out int min,out int average,out int sum)
        {
            max = min = array[0];
            sum = 0;
            foreach(int elem in array)
            {
                if (elem > max)
                {
                    max = elem;
                }
                if (elem < min)
                {
                    min = elem;
                }
                sum += elem;
            }
            average = sum / array.Length;
        }
    }
}
