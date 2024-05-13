using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDivisonHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillDivisonHR(new List<int>() { 3, 10, 2, 9 }, 1, 12);
            BillDivisonHR(new List<int>() { 3, 10, 2, 9 }, 1, 7);
        }
        public static void BillDivisonHR(List<int> bill, int k, int b)
        {
            int sum = bill.Sum();
            sum -= bill[k];
            sum /= 2;
            if (sum == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - sum);
        }
    }
}
