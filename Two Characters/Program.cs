using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Characters
{
    class Program
    {
        static void Main(String[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int maxcount = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    char c1 = s[i];
                    char c2 = s[j];
                    int flag = 0;
                    int count = 0;
                    foreach (char c in s)
                    {
                        if (c == c1)
                        {
                            flag++;
                            count++;
                        }
                        else if (c == c2)
                        {
                            flag--;
                            count++;
                        }
                        if (flag < 0 || 1 < flag) break;
                    }
                    if ((flag == 0 || flag == 1) && count > maxcount) maxcount = count;
                }
            }
            Console.WriteLine(maxcount);
        }
    }
}
