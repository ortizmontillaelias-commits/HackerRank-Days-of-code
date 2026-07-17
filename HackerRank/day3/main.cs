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
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        // Si N es impar (el residuo de dividir entre 2 es diferente de 0)
        if (N % 2 != 0)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            // Si N es par, evaluamos los rangos establecidos
            if (N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}