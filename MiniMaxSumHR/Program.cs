using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSumHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiniMaxSumHR(new List<int>() { 1, 3, 5, 7, 9 });
            MiniMaxSumHR(new List<int>() { 1, 2, 3, 4, 5 });
        }
        public static void MiniMaxSumHR(List<int> arr)
        {
            arr.Sort();
            long minSum = 0, maxSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                minSum += arr[i];
                if (i == 0)
                    continue;
                if (i == arr.Count - 1)
                    minSum -= arr[i];
                maxSum += arr[i];
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
