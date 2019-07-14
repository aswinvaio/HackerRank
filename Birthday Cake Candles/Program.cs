using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int tallestHieght = 0;
            int tallestCount = 0;
            foreach (int height in ar)
            {

                if (height == tallestHieght)
                    tallestCount++;
                if (height > tallestHieght)
                {
                    tallestHieght = height;
                    tallestCount = 1;
                }
            }
            return tallestCount;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            //textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
            Console.WriteLine(result);
        }
    }
}
