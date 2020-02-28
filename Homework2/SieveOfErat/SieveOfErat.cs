using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfErat
{
    class SieveOfErat
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[101];
            for(int k = 2; k <= 100; k++)
            {
                isPrime[k] = true;
            }
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 2; i * j <= 100; j++)
                {
                    if (isPrime[i * j])
                    {
                        isPrime[i * j] = false;
                    }
                }
            }
            Console.WriteLine("2-100以内的素数为：");
            for(int k = 2; k <= 100; k++)
            {
                if (isPrime[k])
                    Console.WriteLine(k);
            }
        }
    }
}
