using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Condition();
                Console.WriteLine("Do you want to exit? Press Y to quit or any key to run the program again");
                var selection = Console.ReadLine();
                if (selection == "Y")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }
        }

        private static double Diametr()
        {
            Console.WriteLine("Enter diametr");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double Radius(double d)
        {
            return d / 2;
        }

        private static double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        private static double Length(double r)
        {
            return 2 * Math.PI * r;
        }

        private static void Circle()
        {
            var diameter = Diametr();

            var radius = Radius(diameter);

            var cirarea = CircleArea(radius);
            Console.WriteLine($"The area of a circle is {cirarea}");

            var length = Length(radius);
            Console.WriteLine($"The circumference is {length}");
        }

        //--------------------

        private static double EnterCat1()
        {
            Console.WriteLine("Enter Cathetus1");
            return Convert.ToDouble(Console.ReadLine());
        }
        private static double EnterCat2()
        {
            Console.WriteLine("Enter Cathetus2");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double Hipotenuse(double c1, double c2)
        {
            return Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));
        }

        private static double TriangleArea(double c1, double c2)
        {
            return 0.5 * c1 * c2;
        }

        private static void Triangle()
        {
            var cat1 = EnterCat1();
            var cat2 = EnterCat2();

            var hip = Hipotenuse(cat1, cat2);
            Console.WriteLine($"The hipothenuse is {hip}");

            var trarea = TriangleArea(cat1, cat2);
            Console.WriteLine($"The area is {trarea}");
        }

        private static void Condition()
        {
            Console.WriteLine("Press 1 to calculate circle area or press 2 to calculate right triangle area. Press some key to quit.");
            var num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 1)
            {
                Circle();
            }

            else if (num1 == 2)
            {
                Triangle();
            }
        }
    }
}
