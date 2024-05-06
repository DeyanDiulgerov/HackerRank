using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotationHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LeftRotationHR(2, new List<int>() { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", LeftRotationHR(4, new List<int>() { 1, 2, 3, 4, 5 })));
        }
        public static List<int> LeftRotationHR(int d, List<int> arr)
        {
            int n = arr.Count;
            int distance = n - d;
            Swap(0, n - 1);
            Swap(distance, n - 1);
            Swap(0, distance - 1);
            void Swap(int left, int right)
            {
                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return arr;
        }
    }
}
