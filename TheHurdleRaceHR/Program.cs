using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHurdleRaceHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TheHurdleRaceHR(1, new List<int>() { 1, 2, 3, 3, 2 }));
            Console.WriteLine(TheHurdleRaceHR(4, new List<int>() { 1, 6, 3, 5, 2 }));
            Console.WriteLine(TheHurdleRaceHR(4, new List<int>() { 1, 2, 3, 3, 2 }));
        }
        public static int TheHurdleRaceHR(int k, List<int> height)
        {
            if (height.Max() <= k)
                return 0;
            return height.Max() - k;
        }
    }
}
