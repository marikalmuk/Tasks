using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var triangleSide1 = ReadDouble("Enter triangle side 1 ");
            var triangleSide2 = ReadDouble("Enter triangle side 2 ");
            var triangleSide3 = ReadDouble("Enter triangle side 3 ");
            var triangleHeight = ReadDouble("Enter triangle height ");
            var triangularPrismLenght = ReadDouble("Enter triangular prizm lenght ");

            double triangularPerimetr = Calculator.Perimeter(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"The trianle perimetr is {triangularPerimetr}");

            var triangularSquare = Calculator.Square(triangleSide1, triangleHeight);
            Console.WriteLine($"The trianle square is {triangularSquare}");

            var triangularVolume = Calculator.Volume(triangleSide1, triangleHeight, triangularPrismLenght);
            Console.WriteLine($"The trianle volume is {triangularVolume}");


            var radius = ReadDouble("Enter circle radius");
            var cylinderHeight = ReadDouble("Enter cylinder Height");

            double circlePerimetr = Calculator.Perimeter(radius);
            Console.WriteLine($"The circle perimetr is {circlePerimetr}");

            double circleSquare = Calculator.Square(radius);
            Console.WriteLine($"The circle square is {circleSquare}");

            double cilinderVolume = Calculator.VolumeCylinder(radius, cylinderHeight);
            Console.WriteLine($"The cilinderVolume is {cilinderVolume}");


            var trapesoidSide1 = ReadDouble("Enter trapesoidSide1 ");
            var trapesoidSide2 = ReadDouble("Enter trapesoidSide2 ");
            var trapesoidSide3 = ReadDouble("Enter trapesoidSide3 ");
            var trapesoidSide4 = ReadDouble("Enter trapesoidSide4 ");
            var trapesoidHeight = ReadDouble("Enter trapesoid height ");
            var prismHeight = ReadDouble("Enter prism height ");

            double trapesoidPerimetr = Calculator.Perimeter(trapesoidSide1, trapesoidSide2, trapesoidSide3, trapesoidSide4);
            Console.WriteLine($"The trapesoid perimetr is {trapesoidPerimetr}");

            double trapesoidSquare = Calculator.Square(trapesoidSide1, trapesoidSide2, trapesoidHeight);
            Console.WriteLine($"The trapesoidSquare is {trapesoidSquare}");

            double prismVolume = Calculator.Perimeter(trapesoidSide1, trapesoidSide2, trapesoidHeight, prismHeight);
            Console.WriteLine($"The prismVolume is {prismVolume}");


            var rectangularSide1 = ReadDouble("Enter rectangularSide1 ");
            var rectangularSide2 = ReadDouble("Enter rectangularSide2 ");
            var rectangularSide3 = ReadDouble("Enter rectangularSide3 ");
            var rectangularSide4 = ReadDouble("Enter rectangularSide4 ");
            var cuboidHeight = ReadDouble("Enter cuboidHeight ");

            double rectangularPerimeter = Calculator.Perimeter(rectangularSide1, rectangularSide2, rectangularSide3, rectangularSide4);
            Console.WriteLine($"The rectangular perimetr is {rectangularPerimeter}");

            double rectangularSquare = Calculator.SquareRectangular(rectangularSide1, rectangularSide2);
            Console.WriteLine($"The rectangular square is {rectangularSquare}");

            double cuboidVolume = Calculator.VolumeCuboid(rectangularSide1, rectangularSide2, cuboidHeight);
            Console.WriteLine($"The cuboid volume is {cuboidVolume}");
        }

        public static double ReadDouble(string s)
        {
            Console.WriteLine(s);
            return Convert.ToDouble(Console.ReadLine());
        }
    }

    class Calculator
    {
        //Triangle
        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        //Circle
        public static double Perimeter(double r)
        {
            return 2 * Math.PI * r;
        }
        //Trapezoid&Rectangle
        public static double Perimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
        ///////////
        //Triangle
        public static double Square(double a, double h)
        {
            return 0.5 * a * h;
        }
        //Circle
        public static double Square(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        //Trapezoid
        public static double Square(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
        //Rectangle
        public static double SquareRectangular(double a, double b)
        {
            return a * b;
        }
        ///////
        //Triangular prism
        public static double Volume(double a, double h, double l)
        {
            return 0.5 * a * h * l;
        }
        //Cylinder
        public static double VolumeCylinder(double r, double h)
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }
        //Prism
        public static double Volume(double a, double b, double h, double h2)
        {
            return (((a + b) / 2) * h) * h2;
        }
        //Cuboid
        public static double VolumeCuboid(double a, double b, double c)
        {
            return a * b * c;
        }


    }


}






