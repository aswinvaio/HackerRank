using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets_alg_imp
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int posN = 0;
            int maxA = int.MinValue;
            int minB = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (maxA < a[i]) maxA = a[i];
            }
            for (int i = 0; i < m; i++)
            {
                if (minB > b[i]) minB = b[i];
            }
            for (int i = maxA; i <= minB; i++)
            {
                bool isOK = true;
                for (int j = 0; j < n; j++)
                {
                    if (i % a[j] != 0)
                    {
                        isOK = false;
                        break;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (b[j] % i != 0)
                    {
                        isOK = false;
                        break;
                    }
                }
                if (isOK) posN++;
            }
            Console.Write(posN);
        }
    }
}
