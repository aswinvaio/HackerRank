using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(String[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[count];
            for (int i = 0; i < count; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(LongestIncreasingSeq(a, count));
        }
        public static int LongestIncreasingSeq(int[] s, int count)
        {
            int[] l = new int[count];
            int[] p = new int[count];
            int max = int.MinValue;

            l[0] = 1;

            for (int i = 0; i < count; i++)
                p[i] = -1;

            for (int i = 1; i < count; i++)
            {
                l[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (s[j] < s[i] && l[j] + 1 > l[i])
                    {
                        l[i] = l[j] + 1;
                        p[i] = j;
                        if (l[i] > max)
                            max = l[i];
                    }
                }
            }
            return max;
        }
    }
}
