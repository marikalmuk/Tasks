using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to calculate circle area or press 2 to calculate right triangle area");
            var num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 1)
            {
                Console.WriteLine("Enter diametr");
                var diametr = Convert.ToDouble(Console.ReadLine());
                var radius = diametr / 2;

                var area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The area of a circle is {area}");

                var length = 2 * Math.PI * radius;
                Console.WriteLine($"The circumference is {length}");
            }

            else if (num1 == 2)
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

            else
            {
                Console.WriteLine("Please, use only 1 or 2 keys");
            }
            
        }
    }
}
