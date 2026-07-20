using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            string even = "";
            string odd = "";

            for (int j = 0; j < s.Length; j++)
            {
                if (j % 2 == 0)
                {
                    even += s[j];
                }
                else
                {
                    odd += s[j];
                }
            }

            Console.WriteLine(even + " " + odd);
        }
    }
}