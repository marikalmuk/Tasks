using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle1 = new Circle(ReadDouble("Enter diametr"));
            circle1.WriteInfo();

            Triangle triangle1 = new Triangle(ReadDouble("Enter Cathetus1"), ReadDouble("Enter Cathetus2"));
            circle1.WriteInfo();

            Trapezoid trap = new Trapezoid(ReadDouble("Enter Base A"), ReadDouble("Enter Base B"));
            Console.WriteLine(trap.Midsegment());
        }
        public static double ReadDouble (string s)
        {
            Console.WriteLine(s);
            return Convert.ToDouble(Console.ReadLine());
        }
    }

    class Circle
    {
        private double _diametr;
        public Circle(double diametr)
        {
            this._diametr = diametr;
        }

        public double Diametr 
        {
            get => _diametr;
        }

        public double Radius
        {
            get => Diametr / 2; 
        }

        public double CircleArea
        {
            get => GetCircleArea(); 
        }

        public double GetCircleArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Length
        {
            get => 2 * Math.PI * Radius; 
        }

        public void WriteInfo()
        {
            Console.WriteLine($"The area of a circle is {CircleArea}");
            Console.WriteLine($"The circumference is {Length}");
        }
    }
    class Triangle
    {
        private double _cat1;
        private double _cat2;
        public Triangle(double cat1, double cat2)
        {
            this._cat1 = cat1;
            this._cat2 = cat2;
        }

        public double Cat1
        {
            get => _cat1;
        }
        public double Cat2
        {
            get => _cat2;
        }

        public double Hipotenuse
        {
            get => Math.Sqrt(Math.Pow(Cat1, 2) + Math.Pow(Cat2, 2));
        }

        public double TriangleArea
        {
            get => 0.5 * Cat1 * Cat2;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"The area of a circle is {Hipotenuse}");
            Console.WriteLine($"The circumference is {TriangleArea}");
        }
    }
    class Trapezoid
    {
        private double _baseA;
        private double _baseB;
        public Trapezoid(double baseA, double baseB)
        {
            this._baseA = baseA;
            this._baseB = baseB;
        }
        public double BaseA
        {
            get => _baseA;
        }
        public double BaseB
        {
            get => _baseB;
        }
        public double Midsegment()
        {
            return (BaseA + BaseB) / 2;
        }
    }
}



