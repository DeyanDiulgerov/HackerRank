using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysAtTheMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeautifulDaysAtTheMovies(20, 23, 6));
        }
        public static int BeautifulDaysAtTheMovies(int i, int j, int k)
        {
            int resultCount = 0;
            for (int num = i; num <= j; num++)
            {
                char[] charNum = num.ToString().ToCharArray();
                charNum = Swap(0, charNum.Length - 1, charNum);
                int revNum = int.Parse(String.Join("", charNum));
                if (Math.Abs(num - revNum) % k == 0)
                    resultCount++;
            }
            return resultCount;
            char[] Swap(int left, int right, char[] charNum)
            {
                while (left < right)
                {
                    char temp = charNum[left];
                    charNum[left] = charNum[right];
                    charNum[right] = temp;
                    left++;
                    right--;
                }
                return charNum;
            }
        }
    }
}
