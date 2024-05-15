using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboardHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ClimbingTheLeaderboardHR(
                new List<int>() { 100, 100, 50, 40, 40, 20, 10 }, new List<int>() { 5, 25, 50, 120 })));
            Console.WriteLine(String.Join(",", ClimbingTheLeaderboardHR(
                new List<int>() { 100, 90, 90, 80, 75, 60 }, new List<int>() { 50, 65, 77, 90, 102 })));
        }
        public static List<int> ClimbingTheLeaderboardHR(List<int> ranked, List<int> player)
        {
            ranked = ranked.Distinct().ToList();
            int n = ranked.Count;
            var resList = new List<int>();
            foreach (int p in player)
            {
                while (n > 0 && p >= ranked[n - 1])
                    n--;
                resList.Add(n + 1);
            }
            return resList;
        }
    }
}
