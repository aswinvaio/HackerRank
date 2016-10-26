using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < n; t++)
            {
                String str = Console.ReadLine();
                char[] s = str.ToCharArray();
                char[] r = str.Reverse<char>().ToArray();
                string res = "Funny";
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (Math.Abs(s[i + 1] - s[i]) != Math.Abs(r[i + 1] - r[i]))
                        res= "Not Funny";
                }
                Console.WriteLine(res);
            }
        }
    }
}
