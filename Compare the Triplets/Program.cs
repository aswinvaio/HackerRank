using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int a = 0, b = 0;
            if (a0 > b0) a++;
            if (b0 > a0) b++;
            if (a1 > b1) a++;
            if (b1 > a1) b++;
            if (a2 > b2) a++;
            if (b2 > a2) b++;

            Console.Write(a + " " + b);

        }
    }
}
