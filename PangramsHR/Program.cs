using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangramsHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PangramsHR("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(PangramsHR("We promptly judged antique ivory buckles for the prize"));
        }
        public static string PangramsHR(string s)
        {
            s = s.ToLower();
            List<char> charS = s.ToCharArray().ToList();
            charS.RemoveAll(x => !char.IsLetter(x));
            var map = new Dictionary<char, int>();
            foreach(char letter in charS)
            {
                if(!map.ContainsKey(letter))
                    map.Add(letter, 1);
                else
                    map[letter]++;
            }
            if(map.Count == 26)
                return "pangram";
            return "not pangram";
        }
    }
}
