using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPasswordHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrongPasswordHR(4, "4700"));
            Console.WriteLine(StrongPasswordHR(1, "9"));
            Console.WriteLine(StrongPasswordHR(1, "z"));
            Console.WriteLine(StrongPasswordHR(2, "fe"));
            Console.WriteLine(StrongPasswordHR(3, "Ab1"));
            Console.WriteLine(StrongPasswordHR(1, "#HackerRank"));
        }
        public static int StrongPasswordHR(int n, string password)
        {
            HashSet<char> specialChars = new HashSet<char>()
            {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'};
            int resCount = 0;
            if (password.All(x => !char.IsDigit(x)))
                resCount++;
            if (password.All(x => !char.IsLower(x)))
                resCount++;
            if (password.All(x => !char.IsUpper(x)))
                resCount++;
            if (password.All(x => !specialChars.Contains(x)))
                resCount++;
            if (password.Length >= 6)
                return resCount;
            else if (password.Length + resCount >= 6)
                return resCount;
            else
                return 6 - (password.Length + resCount) + resCount;
        }
    }
}
