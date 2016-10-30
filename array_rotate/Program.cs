using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_rotate
{
    class Program
    {
        //array rotate
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] b = LeftRotate_(a, n, k);
            foreach (int val in b)
                Console.Write(val + " ");
            Console.WriteLine();
            Console.ReadLine();
        }

        public static int[] LeftRotate_(int[] a, int limit, int count)
        {
            int[] b = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                b[(limit + i - count) % limit] = a[i];
            }
            return b;
        }
        public static int[] LeftRotate(int[] a, int limit, int count)
        {
            int temp;
            for (int n = 0; n < count; n++)
            {
                temp = a[0];
                for (int i = 1; i < limit; i++)
                {
                    a[i - 1] = a[i];
                }
                a[limit - 1] = temp;
            }
            return a;
        }
    }
}
