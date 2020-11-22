﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Hurdle_Race
{
    class Program
    {
        static int hurdleRace(int k, int[] height)
        {
            int dose = 0;
            for(int i=0; i < height.Length; i++)
            {
                if(height[i] > k && height[i] - k > dose)
                {
                    dose = height[i] - k;
                }
            }
            return dose;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
