using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFineHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LibraryFineHR(14, 7, 2018, 5, 7, 2018));//135
            Console.WriteLine(LibraryFineHR(9, 6, 2015, 6, 6, 2015));//45
            Console.WriteLine(LibraryFineHR(9, 12, 2015, 6, 6, 2015));//3000
            Console.WriteLine(LibraryFineHR(9, 12, 2017, 6, 6, 2015));//10000
        }
        public static int LibraryFineHR(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            //1 actual return;
            //2 expected return;
            if (y1 > y2)
                return 10000;
            else if (y1 < y2)
                return 0;
            else if (m1 > m2)
                return (m1 - m2) * 500;
            else if (m1 < m2)
                return 0;
            else if (d1 < d2)
                return 0;
            else if (d1 > d2)
                return (d1 - d2) * 15;
            else
                return 0;
        }
    }
}
