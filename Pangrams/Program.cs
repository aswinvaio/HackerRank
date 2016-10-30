using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int[] usedAlphabets = new int[26];
            string outString = "pangram";
            foreach (char c in s)
            {
                if (65 <= c && c <= 90) usedAlphabets[c - 65] = 1;
                if (97 <= c && c <= 122) usedAlphabets[c - 97] = 1;
            }
            foreach (int a in usedAlphabets)
            {
                if (a != 1) outString = "not pangram";
            }
            Console.WriteLine(outString);
        }
    }
}
