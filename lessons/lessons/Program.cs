
using System;

namespace lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] b = new int[2, 3];
            
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.WriteLine("Y : " + i + ", X : " + j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int y = 0; y < b.GetLength(0); y++)
            {
                for (int x = 0; x < b.GetLength(1); x++)
                {
                    Console.Write(b[y, x] + "\t");

                }
                Console.WriteLine();
            }
            
            Console.ReadLine();



        }
    }
}
