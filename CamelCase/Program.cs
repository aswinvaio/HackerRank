using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int cout = 0;
            foreach (char c in s)
            {
                if (65 <= c && c <= 90)
                {
                    cout++;
                }
            }
            cout++;
            Console.WriteLine(cout);
        }
    }
}
