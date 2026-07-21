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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string binary = Convert.ToString(n, 2);

        int maxCount = 0;
        int currentCount = 0;
        foreach (char digit in binary)
        {
            if (digit == '1')
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0;
            }
        }

        Console.WriteLine(maxCount);
    }
}