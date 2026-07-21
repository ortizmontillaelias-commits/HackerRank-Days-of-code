using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    public Difference(int[] a) {
            elements = a;
        }

        public void computeDifference() {
            int max = elements[0];
            int min = elements[0];
            foreach (int e in elements) {
                if (e > max) max = e;
                if (e < min) min = e;
            }
            maximumDifference = max - min;
        }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}