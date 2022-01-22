
using System;

namespace homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1

            Console.Write("how many elemants will be in arrey : ");

            int b = int.Parse(Console.ReadLine());

            int[] n = new int[b];

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Write element {i}:");
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();

            Console.Clear();

            //2

            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(n[i]);
            }

            Console.ReadLine();

            Console.Clear();
            //3

            int NumberOfEvenNumbers = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    NumberOfEvenNumbers++;
                }

            }
            Console.WriteLine(NumberOfEvenNumbers);

            Console.WriteLine();

            Console.ReadLine();

            Console.Clear();
            
        }
    }
}
