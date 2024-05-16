using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquaresHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SherlockAndSquaresHR(24, 49));//3
            Console.WriteLine(SherlockAndSquaresHR(3, 9));//2
        }
        public static int SherlockAndSquaresHR(int a, int b)
        {
            int resultCount = 0;
            for (int i = 1; i <= 100000; i++)
            {
                if (i > b)
                    break;
                double newNum = Math.Pow(i, 2);
                if (newNum >= a && newNum <= b)
                    resultCount++;
            }
            return resultCount;
        }
    }
}
