using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbersHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PickingNumbersHR(new List<int>() { 1, 1, 2, 2, 4, 4, 5, 5, 5 }));
            Console.WriteLine(PickingNumbersHR(new List<int>() { 4, 6, 5, 3, 3, 1 }));
            Console.WriteLine(PickingNumbersHR(new List<int>() { 1, 2, 2, 3, 1, 2 }));
        }
        public static int PickingNumbersHR(List<int> a)
        {
            a.Sort();
            int max = 0;
            int left = 0, right = 1;
            while (right < a.Count)
            {
                while (right < a.Count() && Math.Abs(a[left] - a[right]) <= 1)
                    right++;
                max = Math.Max(max, right - left);
                left = right;
                right++;
            }
            return max;
        }
    }
}
