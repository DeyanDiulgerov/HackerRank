using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxMinHR(4, new List<int>() { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 }));
            Console.WriteLine(MaxMinHR(3, new List<int>() { 10, 100, 300, 200, 1000, 20, 30 }));
        }
        public static int MaxMinHR(int k, List<int> arr)
        {
            arr.Sort();
            int min = int.MaxValue;
            List<int> newArr = arr.Take(k).ToList();
            min = Math.Min(min, newArr.Max() - newArr.Min());
            int left = 0, right = k;
            while (right < arr.Count)
            {
                newArr.RemoveAt(0);
                newArr.Add(arr[right]);
                right++;
                min = Math.Min(min, newArr.Max() - newArr.Min());
            }
            return min;
        }
    }
}
