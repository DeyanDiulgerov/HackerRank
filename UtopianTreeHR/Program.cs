using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTreeHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UtopianTreeHR(5));//14
            Console.WriteLine(UtopianTreeHR(0));//1
            Console.WriteLine(UtopianTreeHR(1));//2
            Console.WriteLine(UtopianTreeHR(4));//7
        }
        public static int UtopianTreeHR(int n)
        {
            //double -> +1 -> repeat...
            if (n == 0)
                return 1;
            int counter = 1;
            int result = 1;
            while (counter <= n)
            {
                if (counter % 2 != 0)
                    result *= 2;
                else
                    result++;

                counter++;
            }
            return result;
        }
    }
}
