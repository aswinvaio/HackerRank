using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_String
{
    class Program
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            int len = s.Length;
            long count = 0;
            for (int i = 0; i < len; i++) if (s[i] == 'a') count++;
            count = (n / len) * count;
            for (int i = 0; i < (n % len); i++) if (s[i] == 'a') count++;
            Console.WriteLine(count);
        }
    }
}
