using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Breaking_the_Records
{

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int min = scores[0], max = scores[0];
        int[] result = new int[2];
        foreach (int score in scores)
        {
            if (max < score)
            {
                max = score;
                result[0]++;
            }
            if (score < min)
            {
                min = score;
                result[1]++;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
        Console.WriteLine(string.Join(" ", result));
        Console.ReadLine();
    }
}
