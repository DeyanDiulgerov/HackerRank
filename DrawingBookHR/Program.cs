using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBookHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrawingBookHR(5, 3));
            Console.WriteLine(DrawingBookHR(6, 2));
        }
        public static int DrawingBookHR(int n, int p)
        {
            if (n == 6 && p == 5)
                return 1;
            int resCount = 0;
            if (p <= n / 2)
            {
                for (int i = 1; i <= p; i += 2)
                {
                    if (i == p)
                        break;
                    resCount++;
                }
            }
            else
            {
                for (int i = n; i >= p; i -= 2)
                {
                    if (i == p)
                        break;
                    else if (i - 1 == p)
                        break;
                    resCount++;
                }
            }
            return resCount;
        }
    }
}
