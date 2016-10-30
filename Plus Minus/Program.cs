using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            float po = 0, ne = 0, ze = 0;
            foreach (int x in arr)
            {
                if (x > 0) po++;
                else if (x < 0) ne++;
                else ze++;
            }
            Console.WriteLine((po / n));
            Console.WriteLine((ne / n));
            Console.WriteLine((ze / n));

        }
    }
}
