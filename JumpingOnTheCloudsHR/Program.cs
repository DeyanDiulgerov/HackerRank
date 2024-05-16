using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheCloudsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JumpingOnTheCloudsHR(new List<int>() { 0, 1, 0, 0, 0, 1, 0 }));
            Console.WriteLine(JumpingOnTheCloudsHR(new List<int>() { 0, 0, 1, 0, 0, 1, 0 }));
        }
        public static int JumpingOnTheCloudsHR(List<int> c)
        {
            int count = 0;
            for (int i = 0; i < c.Count - 1; i += 0)
            {
                if (i < c.Count - 2 && c[i + 2] == 0)
                    i += 2;
                else
                    i++;
                count++;
            }
            return count;
        }
    }
}
