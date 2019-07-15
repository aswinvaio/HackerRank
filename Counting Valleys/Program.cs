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

class Counting_Valleys
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int level = 0;
        int noOfValleys = 0;
        foreach (char c in s)
        {
            bool inValley = false;
            if (level < 0) inValley = true;
            switch (c)
            {
                case 'U': level++;
                    break;
                case 'D': level--;
                    break;
            }
            
            if (inValley && level == 0)
                noOfValleys++;
        }
        return noOfValleys;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
