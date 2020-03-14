using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEach
{
    class Program
    {

        delegate void Func(string n);

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(rd.Next(100));
            }
            int min = intList[1];
            int max = intList[1];
            int sum = 0;
            Console.WriteLine("随机生成的10个链表元素为");
            intList.ForEach(s =>  Console.WriteLine(s));
            intList.ForEach(e=> { if (e < min) min = e; });
            intList.ForEach(e => { if (e > max) max = e; });
            intList.ForEach(e => sum += e);
            Console.WriteLine($"链表元素的最大值为{max}");
            Console.WriteLine($"链表元素的最小值为{min}");
            Console.WriteLine($"链表元素的和为{sum}");
        }
    }
}
