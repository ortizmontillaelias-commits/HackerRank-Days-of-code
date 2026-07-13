using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // 1. Declarar las variables
        int i2;
        double d2;
        string s2; 

        // 2. Leer y guardar los datos de entrada
        i2 = Convert.ToInt32(Console.ReadLine());
        d2 = Convert.ToDouble(Console.ReadLine());
        s2 = Console.ReadLine();

        // 3. Imprimir la suma de los enteros
        Console.WriteLine(i + i2);
        
        // 4. Imprimir la suma de los doubles (con formato de 1 decimal)
        Console.WriteLine((d + d2).ToString("F1"));
        
        // 5. Concatenar e imprimir los strings
        Console.WriteLine(s + s2);
    }
}