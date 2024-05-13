using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSetsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BetweenTwoSetsHR(new List<int>() { 2, 6 }, new List<int>() { 24, 36 }));
            Console.WriteLine(BetweenTwoSetsHR(new List<int>() { 2, 4 }, new List<int>() { 16, 32, 96 }));
        }
        public static int BetweenTwoSetsHR(List<int> a, List<int> b)
        {
            int res = 0;
            int max = a.Max() >= b.Max() ? a.Max() : b.Max();
            for (int i = 2; i < 100; i++)
            {
                if (i >= max)
                    break;
                bool isFactor = true;
                foreach (int num in a)
                {
                    if (i % num != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }
                if (!isFactor)
                    continue;
                foreach (int num in b)
                {
                    if (num % i != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }
                if (isFactor)
                    res++;
            }
            return res;
        }
    }
}
