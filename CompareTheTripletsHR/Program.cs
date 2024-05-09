using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTripletsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CompareTheTripletsHR(
                new List<int>() { 5, 6, 7 }, new List<int>() { 3, 6, 10 })));
        }
        public static List<int> CompareTheTripletsHR(List<int> a, List<int> b)
        {
            int alicePoints = 0, bobPoints = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    alicePoints++;
                else if (a[i] < b[i])
                    bobPoints++;
            }
            return new List<int>() { alicePoints, bobPoints };
        }
    }
}
