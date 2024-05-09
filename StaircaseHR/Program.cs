using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaircaseHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaircaseHR(4);
            StaircaseHR(10);
        }
        public static void StaircaseHR(int n)
        {
            string staircase = "";
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    staircase += "#";
                else
                    staircase += " ";
            }
            int index = n - 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(staircase);
                if (i == n - 1)
                    break;
                staircase = staircase.Remove(index, 1);
                staircase = staircase.Insert(index, "#");
                index--;
            }
        }
    }
}
