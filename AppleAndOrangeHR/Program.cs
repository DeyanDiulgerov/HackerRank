using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrangeHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppleAndOrangeHR(7, 10, 4, 12, new List<int>() { 2, 3, -4 }, new List<int>() { 3, -2, -4 });
        }
        public static void AppleAndOrangeHR(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0, orangesCount = 0;
            foreach (int apple in apples)
            {
                if (a + apple >= s && a + apple <= t)
                    applesCount++;
            }
            Console.WriteLine(applesCount);
            foreach (int orange in oranges)
            {
                if (b + orange >= s && b + orange <= t)
                    orangesCount++;
            }
            Console.WriteLine(orangesCount);
        }
    }
}
