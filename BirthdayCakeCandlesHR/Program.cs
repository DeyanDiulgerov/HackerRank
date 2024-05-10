using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandlesHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BirthdayCakeCandlesHR(new List<int>() { 4, 4, 1, 3 }));
            Console.WriteLine(BirthdayCakeCandlesHR(new List<int>() { 3, 2, 1, 3 }));
        }
        public static int BirthdayCakeCandlesHR(List<int> candles)
        {
            var map = new Dictionary<int, int>();
            foreach (int candle in candles)
            {
                if (!map.ContainsKey(candle))
                    map.Add(candle, 1);
                else
                    map[candle]++;
            }
            return map.OrderByDescending(x => x.Value).First().Value;
        }
    }
}
