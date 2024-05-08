using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedSumsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BalancedSumsHR(new List<int>() { 5, 6, 8, 11 }));
            Console.WriteLine(BalancedSumsHR(new List<int>() { 1, 2, 3 }));
            Console.WriteLine(BalancedSumsHR(new List<int>() { 1, 2, 3, 3 }));
        }
        public static string BalancedSumsHR(List<int> arr)
        {
            int prefixSum = 0;
            int suffixSum = arr.Sum();
            foreach (int num in arr)
            {
                suffixSum -= num;
                if (prefixSum == suffixSum)
                    return "YES";
                prefixSum += num;
            }
            return "NO";
        }

    }
}
