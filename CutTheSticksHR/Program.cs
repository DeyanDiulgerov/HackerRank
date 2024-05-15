using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheSticksHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", CutTheSticksHR(new List<int>() { 1, 2, 3 })));
            Console.WriteLine(String.Join(",", CutTheSticksHR(new List<int>() { 5, 4, 4, 2, 2, 8 })));
        }
        public static List<int> CutTheSticksHR(List<int> arr)
        {
            arr.Sort();
            List<int> resList = new List<int>();
            while (arr.Count > 0)
            {
                resList.Add(arr.Count);
                int min = arr[0];
                arr.RemoveAll(x => x == min);
            }
            return resList;
        }
    }
}
