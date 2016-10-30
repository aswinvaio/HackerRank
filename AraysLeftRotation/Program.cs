using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraysLeftRotation
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] b = LeftRotate(a, n, k);
            foreach (int val in b)
                Console.Write(val + " ");
        }

        public static int[] LeftRotate(int[] a, int limit, int count)
        {
            int[] b = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                b[(limit + i - count) % limit] = a[i];
            }
            return b;
        }
    }
}
