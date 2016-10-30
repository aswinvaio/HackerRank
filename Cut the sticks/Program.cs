using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_the_sticks
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int arrayhaselemnt;
            while (true)
            {
                arrayhaselemnt = 0;
                int min = 1001;
                int noofcut = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < min && arr[i] > 0)
                    {
                        min = arr[i];
                        arrayhaselemnt++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] >= min)
                    {
                        arr[i] -= min;
                        noofcut++;
                    }
                }
                if (arrayhaselemnt == 0) break;
                Console.WriteLine(noofcut);
            }
        }
    }
}
