using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPdfViewerHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DesignerPdfViewerHR(
                new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, },
                "abc"));
            //9
            Console.WriteLine(DesignerPdfViewerHR(
               new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, },
               "zaba"));
            //28
        }
        public static int DesignerPdfViewerHR(List<int> h, string word)
        {
            var map = new Dictionary<char, int>();
            for (int i = 0; i < h.Count; i++)
                map.Add((char)(i + 97), h[i]);

            int max = 0;
            foreach (char letter in word)
                max = Math.Max(max, map[letter]);
            return max * word.Length;
        }
    }
}
