using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorationHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MarsExplorationHR("SOSSPSSQSSOR"));
            Console.WriteLine(MarsExplorationHR("SOSSOT"));
            Console.WriteLine(MarsExplorationHR("SOSSOSSOS"));
        }
        public static int MarsExplorationHR(string s)
        {
            int resCount = 0;
            for (int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S')
                    resCount++;
                if (s[i + 1] != 'O')
                    resCount++;
                if (s[i + 2] != 'S')
                    resCount++;
            }
            return resCount;
        }
    }
}
