using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6Lets_Review
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            String[] s = new String[t];
            for (int i = 0; i < t; i++)
                s[i] = Console.ReadLine();
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(s[i][j]);
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(s[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
