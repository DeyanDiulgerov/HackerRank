using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleSumPairsHR(5, 5, new List<int>() { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine(DivisibleSumPairsHR(6, 3, new List<int>() { 1, 3, 2, 6, 1, 2 }));
        }
        public static int DivisibleSumPairsHR(int n, int k, List<int> ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        result++;
                }
            }
            return result;
        }
    }
}
