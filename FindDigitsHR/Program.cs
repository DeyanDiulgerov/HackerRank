using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindDigitsHR(124));//3
            Console.WriteLine(FindDigitsHR(111));//3
            Console.WriteLine(FindDigitsHR(10));//1
            Console.WriteLine(FindDigitsHR(12));//2
            Console.WriteLine(FindDigitsHR(1012));//3
        }
        public static int FindDigitsHR(int n)
        {
            int resultCount = 0;
            foreach (char ch in n.ToString())
            {
                int digit = ch - 48;
                if (digit == 0)
                    continue;
                if (n % digit == 0)
                    resultCount++;
            }
            return resultCount;
        }
    }
}
