
using System;

namespace lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] b =
            {
                {2, 3, 4, 5, 6 },
                {2, 3, 4, 5, 6 },
                {2, 3, 4, 5, 6 }
            };
            for (int y = 0; y < b.GetLength(0); y++)
            {
                for (int x = 0; x < b.GetLength(1); x++)
                {
                    Console.WriteLine(b[y, x] + "\t");

                }
                Console.WriteLine();
            }
            
            Console.ReadLine();



        }
    }
}
