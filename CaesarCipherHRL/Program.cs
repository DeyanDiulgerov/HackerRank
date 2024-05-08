using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherHRL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaesarCipherHRL("159357lcfd", 98));
            Console.WriteLine(CaesarCipherHRL("D3q4", 0));
            Console.WriteLine(CaesarCipherHRL("middle-Outz", 2));
        }
        public static string CaesarCipherHRL(string s, int k)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int n = alphabet.Length;
            k %= n;
            Swap(0, n - 1);
            Swap(0, n - k - 1);
            Swap(n - k, n - 1);
            void Swap(int left, int right)
            {
                while (left < right)
                {
                    char temp = alphabet[left];
                    alphabet[left] = alphabet[right];
                    alphabet[right] = temp;
                    left++;
                    right--;
                }
            }
            var map = new Dictionary<char, char>();
            for (int i = 1; i <= 26; i++)
            {
                map.Add((char)(i + 96), alphabet[i - 1]);
            }
            //Console.WriteLine(String.Join(",", map));
            char[] charS = s.ToCharArray();
            for (int i = 0; i < charS.Length; i++)
            {
                if (char.IsDigit(charS[i]))
                    continue;
                if (!char.IsLetterOrDigit(charS[i]))
                    continue;
                if (char.IsUpper(charS[i]))
                {
                    char temp = char.ToLower(charS[i]);
                    charS[i] = char.ToUpper(map[temp]);
                }
                else
                    charS[i] = map[charS[i]];
            }
            return String.Join("", charS);
        }
    }
}
