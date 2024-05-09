using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlusMinusHR(new List<int>() { 1, 1, 0, -1, -1 });
            PlusMinusHR(new List<int>() { -4, 3, -9, 0, 4, 1, });
        }
        public static void PlusMinusHR(List<int> arr)
        {
            int pCount = 0, nCount = 0, zCount = 0;
            int n = arr.Count;
            foreach (int num in arr)
            {
                if (num > 0)
                    pCount++;
                else if (num < 0)
                    nCount++;
                else
                    zCount++;
            }
            double pRes = (double)pCount / n;
            double nRes = (double)nCount / n;
            double zRes = (double)zCount / n;
            Console.WriteLine(pRes.ToString("N6"));
            Console.WriteLine(nRes.ToString("N6"));
            Console.WriteLine(zRes.ToString("N6"));
        }
    }
}
