
using System;

namespace lessons
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5, 1,};

            int b = a.Min();

            int c = a.Max();

            int d = a.Sum();

            int e = a.Where(i => i % 2 == 0).Sum();

            int f = a.Where(i => i % 2 != 0).Min();

            int[] g = a.Distinct().ToArray();

            int[] h = a.OrderBy(i => i).ToArray();

            Console.WriteLine(c);

            Console.WriteLine(b);

            Console.WriteLine(d);

            Console.WriteLine(e);

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
