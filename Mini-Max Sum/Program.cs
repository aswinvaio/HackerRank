using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long min = long.MaxValue;
            long max = long.MinValue;
            long sum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
                sum += arr[i];
            }
            Console.WriteLine((sum - max) + " " + (sum - min));
        }
    }
}
