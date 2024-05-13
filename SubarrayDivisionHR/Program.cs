using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarrayDivisionHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubarrayDivisionHR(new List<int>() { 2, 2, 1, 3, 2 }, 4, 2));
            Console.WriteLine(SubarrayDivisionHR(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2));
        }
        public static int SubarrayDivisionHR(List<int> s, int d, int m)
        {
            int result = 0;
            int sum = s.Take(m).Sum();
            if (sum == d)
                result++;
            int left = 0, right = m;
            while (right < s.Count)
            {
                sum -= s[left];
                sum += s[right];
                if (sum == d)
                    result++;
                left++;
                right++;
            }
            return result;
        }
    }
}
