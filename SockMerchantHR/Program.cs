using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchantHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SockMerchantHR(7, new List<int>() { 1, 2, 1, 2, 1, 3, 2 }));
            Console.WriteLine(SockMerchantHR(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
        }
        public static int SockMerchantHR(int n, List<int> ar)
        {
            var map = new Dictionary<int, int>();
            foreach (int num in ar)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, 1);
                else
                    map[num]++;
            }
            int resCount = 0;
            foreach (var kvp in map)
            {
                if (kvp.Value == 1)
                    continue;
                resCount += kvp.Value / 2;
            }
            return resCount;
        }
    }
}
