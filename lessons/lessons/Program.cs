
using System;

namespace homeworlessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            //зробили масив
            a = new int[2];
            //видилили місце на 5 елементів
            a[1] = 6;
            //положили 6 в другу квартиру
            a[0] = 20;
            //положили 20 в першу квартиру
            int t = a[0];
            //витянули 20 з першоє квартири і положили в зміну  t
            Console.WriteLine(a[1]);
            //вивели другу квартиру в консолі(занчення - 6)
            Console.WriteLine(t);
            //вивели t в консолі(занчення - 20)
            Console.WriteLine(a[0]);
            //вивели першу кваритиру в консолі(занчення - 20)

            object[] b = new object[2];
            b[0] = "Andriy";
            b[1] = 15;
            Console.WriteLine("hi my name is " + b[0] + ", and I`m " + b[1]);
            

            Console.ReadLine();




        }
    }
}
