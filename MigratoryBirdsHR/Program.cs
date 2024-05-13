using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirdsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MigratoryBirdsHR(new List<int>() { 1, 1, 2, 2, 3 }));
            Console.WriteLine(MigratoryBirdsHR(new List<int>() { 1, 4, 4, 4, 5, 3 }));
        }
        public static int MigratoryBirdsHR(List<int> arr)
        {
            var map = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, 1);
                else
                    map[num]++;
            }
            return map
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .First()
                .Key;
        }
    }
}
