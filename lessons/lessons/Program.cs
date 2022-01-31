
using System;

namespace lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[2];
            a[2] = new int[5];

            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = random.Next(100);
                }

            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}
