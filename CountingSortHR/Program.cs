using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSortHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CountingSortHR(new List<int> { 1, 1, 3, 2, 1 })));
        }
        public static List<int> CountingSortHR(List<int> arr)
        {
            int[] res = new int[100];
            for (int i = 0; i < arr.Count; i++)
                res[arr[i]]++;
            return res.ToList();
        }
    }
}
