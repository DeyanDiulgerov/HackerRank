using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeTheArrayHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualizeTheArrayHR(new List<int>() { 1, 2, 2, 3 }));
            Console.WriteLine(EqualizeTheArrayHR(new List<int>() { 3, 3, 1, 2, 3 }));
        }
        public static int EqualizeTheArrayHR(List<int> arr)
        {
            var map = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, 1);
                else
                    map[num]++;
            }
            int max = map.Values.Max();
            int sum = map.Values.Sum();
            return sum - max;
        }
    }
}
