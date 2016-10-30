using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");
                for (int k = n - i - 1; k < n; k++)
                    Console.Write("#");
                Console.WriteLine();
            }
        }
    }
}
