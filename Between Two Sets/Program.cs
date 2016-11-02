using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
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

            int bMin = int.MaxValue;
            for(int i = 0; i < m; i++)
            {
                if (b[i] < bMin) bMin = b[i];
            }
            int aMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > aMax) aMax = a[i];
            }
            int countX = 0;
            for(int i = aMax; i <= bMin; i++)
            {
                bool isX = true;
                for(int j = 0; j < n; j++)
                {
                    if(i%a[j]!=0)
                    {
                        isX = false;
                        break;
                    }
                }
                for(int j = 0; j < m; j++)
                {
                    if (b[j] % i != 0)
                    {
                        isX = false;
                        break;
                    }
                }
                if (isX) countX++;
            }
            Console.WriteLine(countX);
            Console.ReadLine();
        }
    }
}
