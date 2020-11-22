using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Array_Division
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }
                if (sum == d)
                    result++;
            }
            return result ;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
            Console.ReadLine();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
