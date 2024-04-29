using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new List<List<int>>()
            {
                new List<int>(){1,2,3},
                new List<int>(){4,5,6},
                new List<int>(){9,8,9},
            };
            Console.WriteLine(DiagonalDifferenceHR(arr1));
        }
        public static int DiagonalDifferenceHR(List<List<int>> arr)
        {
            int n = arr.Count;
            int row = 0, col = 0;
            int firstSum = 0, secondSum = 0;
            while (row < n && col < n)
            {
                firstSum += arr[row][col];
                row++;
                col++;
            }
            row = 0;
            col = n - 1;
            while (row < n && col > -1)
            {
                secondSum += arr[row][col];
                row++;
                col--;
            }
            return Math.Abs(firstSum - secondSum);
        }
    }
}
