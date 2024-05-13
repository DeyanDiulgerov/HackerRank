using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecordsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", BreakingTheRecordsHR(new List<int>() { 12, 24, 10, 24 })));
            Console.WriteLine(String.Join(",", BreakingTheRecordsHR(new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 })));
        }
        public static List<int> BreakingTheRecordsHR(List<int> scores)
        {
            int min = scores[0];
            int max = scores[0];
            int countMin = 0, countMax = 0;
            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    countMax++;
                    max = scores[i];
                }
                else if (scores[i] < min)
                {
                    countMin++;
                    min = scores[i];
                }
            }
            return new List<int>() { countMax, countMin };
        }
    }
}
