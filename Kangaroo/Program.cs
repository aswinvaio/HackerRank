using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            if (checkIfMeatsAtSameTime(x1, x2, v1, v2))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static bool checkIfMeatsAtSameTime(int x1, int x2, int v1, int v2)
        {
            if ((x1 < x2) && (v1 <= v2) || (x1 > x2) && (v1 >= v2))
                return false;
            if ((x2 - x1) % (v1 - v2) == 0)
                return true;
            return false;
        }
    }
}
