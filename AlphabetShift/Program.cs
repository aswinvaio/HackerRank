using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetShift
{
    class Program
    {
        static void Main(string[] args)
        {
            String inString = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string outString = "";

            foreach (char c in inString)
            {
                if (65 <= c && c <= 90)
                    outString += Convert.ToChar(((c - 65 + n) % 26) + 65);
                else if (97 <= c && c <= 122)
                    outString += Convert.ToChar(((c - 97 + n) % 26) + 97);
                else
                    outString += c;
            }
            Console.WriteLine(outString);
            Console.ReadLine();
        }
    }
}
