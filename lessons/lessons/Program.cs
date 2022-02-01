
using System;

namespace lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,,] a =
            {

                {
                    {1, 2, 3 },
                    {1, 2, 3}
                },

                {
                    {4, 5, 6 },
                    {4, 5 ,6}
                },

                {
                    {7, 8, 9 },
                    {7, 8 ,9}
                }

            };
            Random random = new Random();
            int[,,] b = new int[3, 5, 4];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int t = 0; t < b.GetLength(2); t++)
                    {
                        b[i, j, t] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                Console.WriteLine("page : " + (i +1));
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int t = 0; t < b.GetLength(2); t++)
                    {
                        Console.Write(b[i, j, t] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }






















            Console.ReadLine();



        }
    }
}
