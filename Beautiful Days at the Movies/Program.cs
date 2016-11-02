 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_s[0]);
            int j = Convert.ToInt32(tokens_s[1]);
            int k = Convert.ToInt32(tokens_s[2]);
            int bcount = 0;
            for (int d = i; d <= j; d++)
            {
                if ((Math.Abs(d - reversed(d))) % k == 0)
                {
                    bcount++;
                }
            }
            Console.WriteLine(bcount);
            Console.ReadLine();
        }
        static int reversed(int num)
        {
            int num2 = 0;
            while (num > 0)
            {
                int d= num % 10;
                num2 = num2 * 10 + d;
                num /= 10;
            }
            return num2;
        }
    }
}
