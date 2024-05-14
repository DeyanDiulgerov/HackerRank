using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndAMouseHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CatsAndAMouseHR(2, 5, 4));
            Console.WriteLine(CatsAndAMouseHR(1, 2, 3));
            Console.WriteLine(CatsAndAMouseHR(1, 3, 2));
        }
        static string CatsAndAMouseHR(int x, int y, int z)
        {
            //x == a, y == b, z == mouse
            if (Math.Abs(z - y) < Math.Abs(z - x))
                return "Cat B";
            else if (Math.Abs(z - y) > Math.Abs(z - x))
                return "Cat A";
            else
                return "Mouse C";
        }
    }
}
