using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cathetus1");
            var cat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Cathetus2");
            var cat2 = Convert.ToDouble(Console.ReadLine());

            var hip = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
            Console.WriteLine($"The hipothenuse is {hip}");

            var area = 0.5 * cat1 * cat2;
            Console.WriteLine($"The area is {area}");
        }
    }
}
