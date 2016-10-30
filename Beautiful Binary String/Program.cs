using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Binary_String
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();
            char[] A = B.ToCharArray();
            int count = 0;
            for (int i = 0; i < n - 2; i++)
            {
                if (A[i] == '0' && A[i + 1] == '1' && A[i + 2] == '0')
                {
                    A[i + 2] = '1';
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
