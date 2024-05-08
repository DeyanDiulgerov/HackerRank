using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbersHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MissingNumbersHR(
                new List<int>() { 7, 2, 5, 3, 5, 3 }, new List<int>() { 7, 2, 5, 4, 6, 3, 5, 3 })));
            Console.WriteLine(String.Join(",", MissingNumbersHR(
                new List<int>() { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 },
                new List<int>() { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 })));
        }
        public static List<int> MissingNumbersHR(List<int> arr, List<int> brr)
        {
            var mapA = new Dictionary<int, int>();
            var mapB = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (!mapA.ContainsKey(num))
                    mapA.Add(num, 1);
                else
                    mapA[num]++;
            }
            foreach (int num in brr)
            {
                if (!mapB.ContainsKey(num))
                    mapB.Add(num, 1);
                else
                    mapB[num]++;
            }
            var res = new List<int>();
            foreach (var kvp in mapB)
            {
                if (!mapA.ContainsKey(kvp.Key) || mapA[kvp.Key] < kvp.Value)
                    res.Add(kvp.Key);
            }
            res.Sort();
            return res;
        }
    }
}
