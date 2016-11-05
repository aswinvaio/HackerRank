using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int jumps = 0;

            for(int i = 0; i < n;)
            {
                if (i + 2 < n)
                {
                    if (c[i + 2] == 0)
                    {
                        jumps++;
                        i += 2;
                        continue;
                    }
                }
                if (i + 1 < n)
                {
                    if (c[i + 1] == 0)
                    {
                        jumps++;
                        i += 1;
                        continue;
                    }
                }
                break;
            }
            Console.WriteLine(jumps);
            Console.ReadLine();
        }
    }
}
