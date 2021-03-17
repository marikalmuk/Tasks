using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle circle1 = new Circle();

            Console.WriteLine("Enter diametr");
            circle1.Diametr = Convert.ToDouble(Console.ReadLine());
            circle1.Radius = circle1.GetRadius();
            circle1.CircleArea = circle1.GetCircleArea();
            circle1.Length = circle1.GetLength();
            circle1.WriteInfo();

            //Triangle triangle1 = new Triangle();
            //var catet1 = triangle1.EnterCat1();
            //var catet2 = triangle1.EnterCat2();
            //var hip = triangle1.Hipotenuse(catet1, catet2);
            //Console.WriteLine($"The hipothenuse is {hip}");
            //var trarea = triangle1.TriangleArea(catet1, catet2);
            //Console.WriteLine($"The area is {trarea}");

            //Trapezoid trap = new Trapezoid();
            //var baseA = trap.BaseA();
            //var baseB = trap.BaseB();
            //var midseg = trap.Midsegment(baseA, baseB);
            //Console.WriteLine($"The midsegment is {midseg}");
        }
    }

    class Circle
    {
        private double _diametr;
        private double _radius;
        private double _cirarea;
        private double _length;
        public double Diametr
        {
            get
            { return _diametr; }
            set
            {
                _diametr = value;
            }
        }
        public double Radius
        {
            get
            { return _radius; }
            set
            {
                _radius = value;
            }
        }
        public double GetRadius()
        {
            return _diametr / 2;
        }
        public double CircleArea
        {
            get
            { return _cirarea; }
            set
            {
                _cirarea = value;
            }
        }
        public double GetCircleArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        public double Length
        {
            get
            { return _length; }
            set
            {
                _length = value;
            }
        }
        public double GetLength()
        {
            return 2 * Math.PI * _radius;
        }
        public void WriteInfo()
        {
            Console.WriteLine($"The area of a circle is {_cirarea}");

            Console.WriteLine($"The circumference is {_length}");
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
        public double Midsegment(double a, double b)
        {
            return (a + b) / 2;
        }
    }
}



