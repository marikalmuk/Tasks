using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circle1 = new Circle();
            //var diamentr = circle1.Diametr();
            //var radius = circle1.Radius(diamentr);
            //var cirarea = circle1.CircleArea(radius);
            //Console.WriteLine($"The area of a circle is {cirarea}");
            //var length = circle1.Length(radius);
            //Console.WriteLine($"The circumference is {length}");

            //Triangle triangle1 = new Triangle();

            //var catet1 = triangle1.EnterCat1();
            //var catet2 = triangle1.EnterCat2();
            //var hip = triangle1.Hipotenuse(catet1, catet2);
            //Console.WriteLine($"The hipothenuse is {hip}");
            //var trarea = triangle1.TriangleArea(catet1, catet2);
            //Console.WriteLine($"The area is {trarea}");

            Trapezoid trap = new Trapezoid();
            var baseA = trap.BaseA();
            var baseB = trap.BaseB();
            var midseg = trap.Midsegment(baseA, baseB);
            Console.WriteLine($"The midsegment is {midseg}");

        }
    }

    class Circle
    {
        public double Diametr()
        {
            Console.WriteLine("Enter diametr");
            return Convert.ToDouble(Console.ReadLine());
        }
        public double Radius(double d)
        {
            return d / 2;
        }
        public double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double Length(double r)
        {
            return 2 * Math.PI * r;
        }



    }
    class Triangle
    {
        public double EnterCat1()
        {
            Console.WriteLine("Enter Cathetus1");
            return Convert.ToDouble(Console.ReadLine());
        }
        public double EnterCat2()
        {
            Console.WriteLine("Enter Cathetus2");
            return Convert.ToDouble(Console.ReadLine());
        }
        public double Hipotenuse(double c1, double c2)
        {
            return Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));
        }
        public double TriangleArea(double c1, double c2)
        {
            return 0.5 * c1 * c2;
        }
    }

    class Trapezoid
    {
        public double BaseA()
        {
            Console.WriteLine("Enter Base A");
            return Convert.ToDouble(Console.ReadLine());
        }
        public double BaseB()
        {
            Console.WriteLine("Enter Base B");
            return Convert.ToDouble(Console.ReadLine());
        }
        public double Midsegment (double a, double b)
        {
            return (a + b) / 2;
        }


    }



}



