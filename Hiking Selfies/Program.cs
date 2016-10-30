using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiking_Selfies
{
    class Program
    {
        //WalmartLabs Codesprint (Algorithms)  Hiking Selfies
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            int comb = 0;
            for (int i = 1; i <= n; i++)
            {
                comb += factorial(n) / (factorial(i) * factorial(n - i));
            }
            Console.WriteLine(Math.Abs(x - comb));
        }

        static int factorial(int n)
        {
            int fact = 1;
            for (int i = n; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
